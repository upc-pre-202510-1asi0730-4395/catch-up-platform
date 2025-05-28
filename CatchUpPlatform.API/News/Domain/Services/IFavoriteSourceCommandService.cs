using CatchUpPlatform.API.News.Domain.Model.Aggregates;
using CatchUpPlatform.API.News.Domain.Model.Commands;

namespace CatchUpPlatform.API.News.Domain.Services;

public interface IFavoriteSourceCommandService
{
    /// <summary>
    ///     Handle the create favorite source command.
    /// </summary>
    /// <remarks>
    ///     This method handles the create favorite source command. It checks if the favorite source already exists for the
    ///     given NewsApiKey and SourceId.
    ///     If it does not exist, it creates a new favorite source and adds it to the database.
    /// </remarks>
    /// <param name="command">CreateFavoriteSourceCommand command</param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    Task<FavoriteSource?> Handle(CreateFavoriteSourceCommand command);
}