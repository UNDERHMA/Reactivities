using Domain;
using MediatR;
using Persistence;

namespace Application.Activities
{
    public class Create
    {
        public class Command : IRequest {

            public Activity Activity { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context; 
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                _context.Activities.Add(request.Activity); //does not access db, just adds activity in memory to context

                await _context.SaveChangesAsync(); //saves changes to database asynchronously
                return Unit.Value; // equivalent to nothing, just lets API Controller know it completed
            }
        }
    }
}