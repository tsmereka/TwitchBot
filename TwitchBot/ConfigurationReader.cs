﻿using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace TwitchBot
{
    internal class ConfigurationReader
    {
		public ConfigurationReader(string configFileName)
		{
            _configFileName = configFileName;
            ReadConfig();
		}

        // Default time between messages
        private const int DEFAULT_MESSAGE_INTERVAL = 120;
        // Minimum time between messages
        private const int MINIMUM_MESSAGE_INTERVAL = 30;
        // Default currency name
        private const string DEFAULT_CURRENCY_NAME = "cheddar";
        // Default amount of currency earned per minute
        private const int DEFAULT_CURRENCY_EARN_RATE = 100;
        // Default minimum amount to gamble
        private const int DEFAULT_MINIMUM_GAMBLE_AMOUNT = 50;
        // Default minimum amount of seconds between allowed gamble attempts
        private const int DEFAULT_MINIMUM_GAMBLE_INTERVAL = 60;
        // Default chance to win. The chance to win must be between zero and one.
        private const double DEFAULT_WIN_CHANCE = 0.5;

        private string _configFileName;
        private List<string> _configuredMessages = null;
        private int? _configuredMessageInterval = null;
        private bool _currencyEnabled = false;
        private string _currencyName = DEFAULT_CURRENCY_NAME;
        private int _currencyEarnRate = DEFAULT_CURRENCY_EARN_RATE;
        private bool _gamblingEnabled = false;
        private int _minimumGambleAmount = DEFAULT_MINIMUM_GAMBLE_AMOUNT;
        private int _minimumSecondsBetweenGambles = DEFAULT_MINIMUM_GAMBLE_INTERVAL;
        private double _winChance = DEFAULT_WIN_CHANCE;

        public List<string> GetConfiguredMessages
        {
            get { return _configuredMessages; }
        }

        public int GetConfiguredMessageIntervalInSeconds
        {
            get { return _configuredMessageInterval ?? DEFAULT_MESSAGE_INTERVAL; }
        }

        public bool IsCurrencyEnabled
        {
            get { return _currencyEnabled; }
        }

        public string CurrencyName
        {
            get { return _currencyName ?? DEFAULT_CURRENCY_NAME; }
        }

        public int CurrencyEarnedPerMinute
        {
            get { return (!IsCurrencyEnabled || _currencyEarnRate < 0) ? 0 : _currencyEarnRate; }
        }

        public bool IsGamblingEnabled
        {
            get { return IsCurrencyEnabled && _gamblingEnabled; }
        }

        public int MinimumGambleAmount
        {
            get { return IsGamblingEnabled ? _minimumGambleAmount : 0; }
        }

        public int MinimumSecondsBetweenGambles
        {
            get { return IsGamblingEnabled ? _minimumSecondsBetweenGambles : 0; }
        }

        public double ChanceToWin
        {
            get { return IsCurrencyEnabled ? _winChance : 0; }
        }

        private void ReadConfig()
        {
            if (string.IsNullOrEmpty(_configFileName))
            {
                return;
            }

            Stream configStream = new FileStream(_configFileName, FileMode.Open, FileAccess.Read);
            XmlDocument document = new XmlDocument();
            document.Load(configStream);

            XmlNode intervalNode = document.DocumentElement.SelectSingleNode("/config/interval");
            XmlAttributeCollection attributes;
            XmlNode waitTimeNode;
            if (intervalNode != null && (attributes = intervalNode.Attributes) != null && (waitTimeNode = attributes.GetNamedItem("wait-time")) != null)
            {
                string value = waitTimeNode.Value;
                _configuredMessageInterval = int.Parse(value);
                if (_configuredMessageInterval < MINIMUM_MESSAGE_INTERVAL)
                {
                    _configuredMessageInterval = MINIMUM_MESSAGE_INTERVAL;
                }
            }
            else
            {
                _configuredMessageInterval = DEFAULT_MESSAGE_INTERVAL;
            }

            XmlNodeList messagesList = document.DocumentElement.SelectNodes("/config/messages/message");
            if (messagesList != null)
            {
                _configuredMessages = new List<string>();
                foreach( XmlNode messageNode in messagesList)
                {
                    if (messageNode != null && !string.IsNullOrEmpty(messageNode.InnerText))
                    {
                        _configuredMessages.Add(messageNode.InnerText);
                    }
                }
            }

            XmlNode currencyNode = document.DocumentElement.SelectSingleNode("/config/currency");
            if ( currencyNode != null )
            {
                _currencyEnabled = true;
                attributes = intervalNode.Attributes;
                if ( attributes != null )
                {
                    XmlNode customNameNode = attributes.GetNamedItem("custom-name");
                    XmlNode earnRateNode = attributes.GetNamedItem("earn-rate");
                    string value;
                    
                    if ( customNameNode != null && !string.IsNullOrEmpty( value = customNameNode.Value ) )
                    {
                        _currencyName = value;
                    }
                    if ( earnRateNode != null && !string.IsNullOrEmpty( value = earnRateNode.Value ) )
                    {
                        int earnRate;
                        bool parsed = int.TryParse( value, out earnRate );
                        if ( parsed && earnRate > 0 )
                        {
                            _currencyEarnRate = earnRate;
                        }
                    }
                }
            }

            XmlNode gamblingNode = document.DocumentElement.SelectSingleNode("/config/gambling");
            if ( gamblingNode != null )
            {
                _gamblingEnabled = true;
                attributes = intervalNode.Attributes;
                if (attributes != null)
                {
                    XmlNode minimumGambleAmountNode = attributes.GetNamedItem("minimum");
                    XmlNode gamblingFrequencyNode = attributes.GetNamedItem("frequency");
                    XmlNode oddsNode = attributes.GetNamedItem("odds");
                    string value;

                    if (minimumGambleAmountNode != null && !string.IsNullOrEmpty(minimumGambleAmountNode.Value))
                    {
                        value = minimumGambleAmountNode.Value;
                        int gambleMinimum;
                        bool parsed = int.TryParse(value, out gambleMinimum);
                        if (parsed && gambleMinimum > 0)
                        {
                            _minimumGambleAmount = gambleMinimum;
                        }
                    }
                    if (gamblingFrequencyNode != null && !string.IsNullOrEmpty(gamblingFrequencyNode.Value))
                    {
                        value = gamblingFrequencyNode.Value;
                        int gamblingFrequency;
                        bool parsed = int.TryParse(value, out gamblingFrequency);
                        if (parsed && gamblingFrequency > 0)
                        {
                            _minimumSecondsBetweenGambles = gamblingFrequency;
                        }
                    }
                    if (oddsNode != null && !string.IsNullOrEmpty(gamblingFrequencyNode.Value))
                    {
                        value = gamblingFrequencyNode.Value;
                        double odds;
                        bool parsed = double.TryParse(value, out odds);
                        if (parsed && odds >= 0 && odds <= 1)
                        {
                            _winChance = odds;
                        }
                    }
                }
            }

            configStream.Close();
        }
    }
}
