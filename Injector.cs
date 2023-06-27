namespace Sportsbot
{
    using Microsoft.Extensions.DependencyInjection;

    public static class Injector
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public static IServiceProvider ServiceProvider { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        private static IServiceCollection? _serviceCollection;
        private static bool _isInitialized = false;

        public static void Init()
        {
            if (!_isInitialized)
            {
                var serviceCollection = new ServiceCollection();
                var serviceProvider = serviceCollection
                    .BuildServiceProvider();

                _serviceCollection = serviceCollection;
                ServiceProvider = serviceProvider;
                _isInitialized = true;
            }
        }

        public static void RegisterType<TInterface, TImplementation>()
            where TInterface : class
            where TImplementation : class, TInterface
        {
            if (_serviceCollection is not null)
            {
                _serviceCollection.AddSingleton<TInterface, TImplementation>();
                ServiceProvider = _serviceCollection.BuildServiceProvider();
            }
        }

        public static void RegisterInstance<TInterface>(TInterface instance)
            where TInterface : class
        {
            if (_serviceCollection is not null)
            {
                _serviceCollection.AddSingleton<TInterface>(instance);
                ServiceProvider = _serviceCollection.BuildServiceProvider();
            }
        }
    }
}
