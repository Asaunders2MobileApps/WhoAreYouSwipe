using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace SwipeGesture
{
    class ViewModel
    {
        String[] Questions = new string[] { "Who is this tool used by?", "Ezio is: ", "Leonardo is: ", "Viere is: ", "Desonmond is: ", "This knight is: ", "What does this logo represent?" };
        String[] GoodAnswers = new string[] {"Members of the Brotherhood", "The leader of the Brotherhood", "A great inventor and partner", "Our main target", "My ancestor", "A puppet", "The Brotherhood" };
        String[] EvilAnswers = new string[] { "A group of Rebels", "The leader of the Rebels", "A traiter that must be eliminated", "Our leader", "A threat to the Templars", "A protector", "The Rebels" };
        int[] score = {0, 0, 0, 0, 0, 0, 0 };

        public event PropertyChangedEventHandler PropertyChanged;

        public string Question
        {
            set
            {
                //OnPropertyChanged("Question");
            }
            get
            {
                //return Questions[i];
                return Questions.ToString();
            }
        }

        public string Good
        {
            set
            {
                //OnPropertyChanged("GoodAnswers");
                //score[1] += 1;
            }
            get
            {
                //return GoodAnswers[i];
                return GoodAnswers.ToString();
            }
        }

        public string Evil
        {
            set
            {
                //OnPropertyChanged("EvilAnswers");
                //score[0] += 1;
            }
            get
            {
                //return EvilAnswers[i];
                return EvilAnswers.ToString();
            }
        }

        public ICommand GetScore { protected set; get; }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
