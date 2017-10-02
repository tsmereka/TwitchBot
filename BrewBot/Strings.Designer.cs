﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BrewBot {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BrewBot.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid bet amount, {0}!.
        /// </summary>
        internal static string Casino_InvalidBetAmount {
            get {
                return ResourceManager.GetString("Casino_InvalidBetAmount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The casino is not currently operating, @{0}!.
        /// </summary>
        internal static string Casino_NotOperating {
            get {
                return ResourceManager.GetString("Casino_NotOperating", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BrewBot is exiting chat. See you soon! BloodTrail.
        /// </summary>
        internal static string ChannelExited {
            get {
                return ResourceManager.GetString("ChannelExited", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HeyGuys BrewBot ready for action!.
        /// </summary>
        internal static string ChannelJoined {
            get {
                return ResourceManager.GetString("ChannelJoined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @{0}, choose from {1}, {2}, {3} or {4}..
        /// </summary>
        internal static string ChoosePlayer {
            get {
                return ResourceManager.GetString("ChoosePlayer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to That command is on cooldown to avoid spamming chat..
        /// </summary>
        internal static string CommandOnCooldown {
            get {
                return ResourceManager.GetString("CommandOnCooldown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry @{0}, your command was invalid. Use !commands to get a list of commands..
        /// </summary>
        internal static string Commands_InvalidCommand {
            get {
                return ResourceManager.GetString("Commands_InvalidCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Welcome to the channel! We&apos;re playing a drinking game. If you want to join, type \&quot;!join &lt;player&gt;\&quot;. Current players are {0}, {1}, {2} and {3}. Type \&quot;!quit\&quot; to stop playing..
        /// </summary>
        internal static string DrinkingGame_Introduction {
            get {
                return ResourceManager.GetString("DrinkingGame_Introduction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A drinking game has been started! Type \&quot;!join &lt;player&gt;\&quot; to play. Current players are @{0}, {1}, {2} and {3}. Type \&quot;!quit\&quot; to stop playing..
        /// </summary>
        internal static string DrinkingGame_Start {
            get {
                return ResourceManager.GetString("DrinkingGame_Start", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @{0}, you have {1} tickets..
        /// </summary>
        internal static string DrinkTicketsBalance {
            get {
                return ResourceManager.GetString("DrinkTicketsBalance", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @{0}, FINISH your drink!.
        /// </summary>
        internal static string FinishDrink {
            get {
                return ResourceManager.GetString("FinishDrink", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to What kind of weeny bet is this!?  Bet at least @{0} @{1}!.
        /// </summary>
        internal static string Gamble_BelowMinimumBet {
            get {
                return ResourceManager.GetString("Gamble_BelowMinimumBet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your funds are grossly insufficient, @{0}!.
        /// </summary>
        internal static string Gamble_InsufficentFunds {
            get {
                return ResourceManager.GetString("Gamble_InsufficentFunds", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @{0}, you {1} {2} {3}!.
        /// </summary>
        internal static string Gamble_Result {
            get {
                return ResourceManager.GetString("Gamble_Result", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @{0}, your balance is {1} {2}.
        /// </summary>
        internal static string GetBalance_Result {
            get {
                return ResourceManager.GetString("GetBalance_Result", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @{0}, you got a drink ticket. Use &quot;!give &lt;player&gt;&quot; to give it to someone and make them drink..
        /// </summary>
        internal static string GetDrinkTicket {
            get {
                return ResourceManager.GetString("GetDrinkTicket", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @{0}, we&apos;re not currently playing a drinking game..
        /// </summary>
        internal static string NoDrinkingGame {
            get {
                return ResourceManager.GetString("NoDrinkingGame", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @{0}, you do not have any drink tickets to give..
        /// </summary>
        internal static string NoDrinkTickets {
            get {
                return ResourceManager.GetString("NoDrinkTickets", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @{0}, {1} is not participating..
        /// </summary>
        internal static string NotParticipating {
            get {
                return ResourceManager.GetString("NotParticipating", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Welcome @{0} to the {1}!.
        /// </summary>
        internal static string SubscriptionReceived {
            get {
                return ResourceManager.GetString("SubscriptionReceived", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Welcome @{0} to the {1}! So kind of you to use your Twitch Prime on this channel!.
        /// </summary>
        internal static string SubscriptionReceivedPrime {
            get {
                return ResourceManager.GetString("SubscriptionReceivedPrime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @{0}, take a drink..
        /// </summary>
        internal static string TakeDrink {
            get {
                return ResourceManager.GetString("TakeDrink", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @{0}, you have taken {1} drinks!.
        /// </summary>
        internal static string TotalDrinksTaken {
            get {
                return ResourceManager.GetString("TotalDrinksTaken", resourceCulture);
            }
        }
    }
}
