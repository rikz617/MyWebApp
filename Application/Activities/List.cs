using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using EFCoreDataAccess.DataAccess;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Application.Activities
{
    public class List
    {

        public class Query : IRequest<List<Activity>> { }
        public class Handler : IRequestHandler<Query, List<Activity>>
        {
            private readonly PeopleContext _context;
            private readonly ILogger<List> _logger;

            public Handler(PeopleContext context, ILogger<List> logger)
            {
                _context = context;
                _logger = logger;
            }

            public async Task<List<Activity>> Handle(Query request, CancellationToken cancellationToken)
            {
                // to test cancellatin token

                //try
                //{
                //    for (int i = 0; i < 10; i++)
                //    {
                //        cancellationToken.ThrowIfCancellationRequested();
                //        await Task.Delay(1000, cancellationToken);
                //        _logger.LogInformation($"Task {i} has completed");
                //    }
                //}
                //catch (System.Exception ex) when (ex is TaskCanceledException)
                //{
                   _logger.LogInformation("Task was Cancelled");
                //}
                
                //var activities = await _context.Activities.ToListAsync(cancellationToken);
                
                var activities = await _context.Activities.ToListAsync();
                return activities;
            }
        }
    }
}