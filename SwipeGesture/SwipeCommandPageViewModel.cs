﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace SwipeGesture
{
    public class SwipeCommandPageViewModel : INotifyPropertyChanged
    {
        String[] Questions = new string[] { "Who is this tool used by?", "Ezio is: ", "Leonardo is: ", "Viere is: ", "Desonmond is: ", "This knight is: ", "What does this logo represent?" };
        String[] GoodAnswers = new string[] {"Members of the Brotherhood", "The leader of the Brotherhood", "A great inventor and partner", "Our main target", "My ancestor", "A puppet", "The Brotherhood" };
        String[] EvilAnswers = new string[] { "A group of Rebels", "The leader of the Rebels", "A traiter that must be eliminated", "Our leader", "A threat to the Templars", "A protector", "The Rebels" };
        int[] score = {0, 0};
        int i = 0;
        private string character = "";

        public event PropertyChangedEventHandler PropertyChanged;

        public string Question
        {
            set
            {
                OnPropertyChanged("Question");
            }
            get
            {
                return Questions[i];
            }
        }

        public string Good
        {
            set
            {
                OnPropertyChanged("GoodAnswers");
                score[1] += 1;
            }
            get
            {
                return GoodAnswers[i];
            }
        }

        public string Evil
        {
            set
            {
                OnPropertyChanged("EvilAnswers");
                score[0] += 1;
            }
            get
            {
                return EvilAnswers[i];
            }
        }

        public ICommand GetScore { protected set; get; }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string ImagePath
        {
            get { return string.Format("image" + i + ".png"); }
        }

        public ICommand SwipeCommand => new Command<string>(Swipe);
        public string SwipeDirection { get; private set; }

        public string Character {
            get { return character; }
            private set {
                if (score[0] > score[1])
                {
                    if (score[0] < 3)
                    {
                        character = "Ezio the main assassin and ancestor to desmond. You lead a large group of assassins in your conquest to bring justice to Italy and restore the Assassin's Order. You biggest nemisis is Vivere de Pazzi";
                    }
                    else
                    {
                        character = "Desmond you are hunted by the templar order and visit your ancestors memories in order to learn how to save the world from being destroyed.";
                    }
                }
                else
                {
                    if (score[1] < 3)
                    {
                        character = "Leonardo Da Vinci, you are a gifted inventor and helped Ezio create many of the tools he used to restore order.";
                    }
                    else
                    {
                        character = "Viere de Pazzi, you want to destroy the Assassin's Order and control the people of Italy.";
                    }
                }
            }
                
        }

        public SwipeCommandPageViewModel()
        {
            SwipeDirection = "You swiped: ";
        }

        void Swipe(string value)
        {
            i += 1;
            if (i <= 6)
            {
                if (value.Equals("Left"))
                {
                    score[0]++;
                    SwipeDirection = $"You swiped: left..... i = " + i;
                    OnPropertyChanged("SwipeDirection");
                }
                else if (value.Equals("Right"))
                {
                    score[1]++;
                    SwipeDirection = $"You swiped: right..... i = " + i;
                    OnPropertyChanged("SwipeDirection");
                }
                OnPropertyChanged("Question");
                OnPropertyChanged("Good");
                OnPropertyChanged("Evil");
                OnPropertyChanged("ImagePath");
            }
            else
            {
                OnPropertyChanged("Character");
            }
        }
    }
}
