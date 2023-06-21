using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C8_Exercises.ViewModel
{
    public partial class ChatViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<ImageSource> _imageSourceUserPhoto;

        [ObservableProperty]
        private ObservableCollection<Message> _showMessage;

        public ChatViewModel()
        {
            GetUserImages();
            GetCategoryList();
        }

        private void GetUserImages()
        {
            ImageSourceUserPhoto = new ObservableCollection<ImageSource>();
            ImageSourceUserPhoto.Add("user2");
            ImageSourceUserPhoto.Add("user3");
            ImageSourceUserPhoto.Add("user4");
            ImageSourceUserPhoto.Add("user5");
            ImageSourceUserPhoto.Add("user2");
            ImageSourceUserPhoto.Add("user3");
            ImageSourceUserPhoto.Add("user4");
            ImageSourceUserPhoto.Add("user5");
            ImageSourceUserPhoto.Add("user2");
            ImageSourceUserPhoto.Add("user3");
            ImageSourceUserPhoto.Add("user4");
            ImageSourceUserPhoto.Add("user5");
            ImageSourceUserPhoto.Add("user2");
            ImageSourceUserPhoto.Add("user3");
            ImageSourceUserPhoto.Add("user4");
            ImageSourceUserPhoto.Add("user5");
            ImageSourceUserPhoto.Add("user2");
            ImageSourceUserPhoto.Add("user3");
            ImageSourceUserPhoto.Add("user4");
            ImageSourceUserPhoto.Add("user5");
        }
        private void GetCategoryList()
        {
            ShowMessage = new ObservableCollection<Message>()
            {
                new Message(){ ProfilePhoto = "user5",Name="Happy Hour",MessageSent="Keep Smiling...",IsUnReadMessage = true,UnreadMessage = "2"},
                new Message(){ ProfilePhoto = "user2",Name="Joey",MessageSent="How you doin?.....",IsUnReadMessage = true,UnreadMessage = "2"},
                new Message(){ ProfilePhoto = "user2",Name="Amey",MessageSent="Hey, hi how are you?",IsUnReadMessage = false,UnreadMessage = string.Empty, Time = "12:00 PM"},
                new Message(){ ProfilePhoto = "user4",Name="Jack",MessageSent="Good evening!...",IsUnReadMessage = false,UnreadMessage = string.Empty, Time = "6:00 PM"},
                new Message(){ ProfilePhoto = "user3",Name="Justice League",MessageSent="Good morning robin..",IsUnReadMessage = false,UnreadMessage = string.Empty,  Time = "2:45 PM"},
                new Message(){ ProfilePhoto = "user5",Name="Ross",MessageSent="I am dinosaur guy",IsUnReadMessage = false,UnreadMessage = string.Empty,  Time = "1:58 PM"},
                new Message(){ ProfilePhoto = "user5",Name="Happy Hour",MessageSent="Keep Smiling...",IsUnReadMessage = true,UnreadMessage = "2"},
                new Message(){ ProfilePhoto = "user2",Name="Joey",MessageSent="How you doin?.....",IsUnReadMessage = true,UnreadMessage = "2"},
                new Message(){ ProfilePhoto = "user2",Name="Amey",MessageSent="Hey, hi how are you?",IsUnReadMessage = false,UnreadMessage = string.Empty, Time = "12:00 PM"},
                new Message(){ ProfilePhoto = "user4",Name="Jack",MessageSent="Good evening!...",IsUnReadMessage = false,UnreadMessage = string.Empty, Time = "6:00 PM"},
                new Message(){ ProfilePhoto = "user3",Name="Justice League",MessageSent="Good morning robin..",IsUnReadMessage = false,UnreadMessage = string.Empty,  Time = "2:45 PM"},
                new Message(){ ProfilePhoto = "user5",Name="Ross",MessageSent="I am dinosaur guy",IsUnReadMessage = false,UnreadMessage = string.Empty,  Time = "1:58 PM"},
                new Message(){ ProfilePhoto = "user5",Name="Happy Hour",MessageSent="Keep Smiling...",IsUnReadMessage = true,UnreadMessage = "2"},
                new Message(){ ProfilePhoto = "user2",Name="Joey",MessageSent="How you doin?.....",IsUnReadMessage = true,UnreadMessage = "2"},
                new Message(){ ProfilePhoto = "user2",Name="Amey",MessageSent="Hey, hi how are you?",IsUnReadMessage = false,UnreadMessage = string.Empty, Time = "12:00 PM"},
                new Message(){ ProfilePhoto = "user4",Name="Jack",MessageSent="Good evening!...",IsUnReadMessage = false,UnreadMessage = string.Empty, Time = "6:00 PM"},
                new Message(){ ProfilePhoto = "user3",Name="Justice League",MessageSent="Good morning robin..",IsUnReadMessage = false,UnreadMessage = string.Empty,  Time = "2:45 PM"},
                new Message(){ ProfilePhoto = "user5",Name="Ross",MessageSent="I am dinosaur guy",IsUnReadMessage = false,UnreadMessage = string.Empty,  Time = "1:58 PM"},
                new Message(){ ProfilePhoto = "user5",Name="Happy Hour",MessageSent="Keep Smiling...",IsUnReadMessage = true,UnreadMessage = "2"},
                new Message(){ ProfilePhoto = "user2",Name="Joey",MessageSent="How you doin?.....",IsUnReadMessage = true,UnreadMessage = "2"},
                new Message(){ ProfilePhoto = "user2",Name="Amey",MessageSent="Hey, hi how are you?",IsUnReadMessage = false,UnreadMessage = string.Empty, Time = "12:00 PM"},
                new Message(){ ProfilePhoto = "user4",Name="Jack",MessageSent="Good evening!...",IsUnReadMessage = false,UnreadMessage = string.Empty, Time = "6:00 PM"},
                new Message(){ ProfilePhoto = "user3",Name="Justice League",MessageSent="Good morning robin..",IsUnReadMessage = false,UnreadMessage = string.Empty,  Time = "2:45 PM"},
                new Message(){ ProfilePhoto = "user5",Name="Ross",MessageSent="I am dinosaur guy",IsUnReadMessage = false,UnreadMessage = string.Empty,  Time = "1:58 PM"},
                new Message(){ ProfilePhoto = "user5",Name="Happy Hour",MessageSent="Keep Smiling...",IsUnReadMessage = true,UnreadMessage = "2"},
                new Message(){ ProfilePhoto = "user2",Name="Joey",MessageSent="How you doin?.....",IsUnReadMessage = true,UnreadMessage = "2"},
                new Message(){ ProfilePhoto = "user2",Name="Amey",MessageSent="Hey, hi how are you?",IsUnReadMessage = false,UnreadMessage = string.Empty, Time = "12:00 PM"},
                new Message(){ ProfilePhoto = "user4",Name="Jack",MessageSent="Good evening!...",IsUnReadMessage = false,UnreadMessage = string.Empty, Time = "6:00 PM"},
                new Message(){ ProfilePhoto = "user3",Name="Justice League",MessageSent="Good morning robin..",IsUnReadMessage = false,UnreadMessage = string.Empty,  Time = "2:45 PM"},
                new Message(){ ProfilePhoto = "user5",Name="Ross",MessageSent="I am dinosaur guy",IsUnReadMessage = false,UnreadMessage = string.Empty,  Time = "1:58 PM"},




            };



        }
    }
}
