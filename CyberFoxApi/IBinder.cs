using DryIoc;

namespace Sansagol.CyberFox.CyberFoxApi
{
    /// <summary>
    /// Interface represents a class which bind all rependencies.
    /// </summary>
    interface IBinder
    {
        /// <summary>
        /// The property gets the main DI container.
        /// </summary>
        Container MainContainer { get; }
    }
}
