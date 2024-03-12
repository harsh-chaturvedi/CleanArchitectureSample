using CleanArchitecture.Application.Commands;
using MediatR;

namespace CleanArchitecture.API;

public static class DependencyInjection
{
    public static IServiceCollection AddAPI(this IServiceCollection services)
    {
        services.AddMediatR(typeof(CreatePerson));
        services.AddControllers(options =>
        {
            options.SuppressAsyncSuffixInActionNames = false;
        });
        return services;
    }

}
