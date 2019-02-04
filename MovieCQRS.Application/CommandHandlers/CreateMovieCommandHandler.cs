using System;
using MovieCQRS.Domain.Models;
using MovieSQRS.Contracts.Command;
using SimpleCqrs.Commanding;
using SimpleCqrs.Domain;

namespace MovieCQRS.Application.CommandHandlers
{
    public enum CreateMovieStatus
    {
        Successful
    }
    
    public class CreateMovieCommandHandler : CommandHandler<CreateMovieCommand>
    {
        protected IDomainRepository _repository;

        public CreateMovieCommandHandler(IDomainRepository repository)
        {
            _repository = repository;
        }

        protected CreateMovieStatus ValidateCommand(CreateMovieCommand command)
        {
            return CreateMovieStatus.Successful;
        }
        
        public override void Handle(CreateMovieCommand command)
        {
            Return(ValidateCommand(command));

            var location = new Movie(Guid.NewGuid(), command.Title, command.ReleaseDate, command.RunningTimeMinutes);

            _repository.Save(location);
        }
    }
}