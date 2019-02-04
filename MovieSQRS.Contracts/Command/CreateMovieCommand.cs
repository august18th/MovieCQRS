using System;
using SimpleCqrs.Commanding;

namespace MovieSQRS.Contracts.Command
{
    public class CreateMovieCommand : ICommand
    {
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int RunningTimeMinutes { get; set; }

        public CreateMovieCommand(string title, DateTime releaseDate, int runningTime)
        {
            Title = title;
            ReleaseDate = releaseDate;
            RunningTimeMinutes = runningTime;
        }
        
        
    }
}