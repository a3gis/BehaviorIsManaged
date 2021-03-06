﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BiM.Behaviors;
using BiM.Behaviors.Game.Actors.RolePlay;

namespace BiM.Host.UI.Bot
{
    /// <summary>
    /// Interaction logic for BotControl.xaml
    /// </summary>
    public partial class BotControl : UserControl
    {
        public BotControl(Behaviors.Bot bot)
        {
            Bot = bot;
            InitializeComponent();

            bot.CharactersSelected += OnCharacterSelected;
        }

        private void OnCharacterSelected(Behaviors.Bot bot, PlayedCharacter character)
        {
            
        }

        /// <summary>
        /// Returns true when the associated bot is disposed and not usable anymore
        /// </summary>
        public bool IsDeadWindow
        {
            get { return Bot.Disposed; }
        }

        public Behaviors.Bot Bot
        {
            get;
            private set;
        }

    }
}
