using CatchUpPlatform.API.News.Domain.Model.Aggregates;
using CatchUpPlatform.API.News.Domain.Model.Commands;
using CatchUpPlatform.API.News.Domain.Repositories;
using CatchUpPlatform.API.News.Domain.Services;
using CatchUpPlatform.API.Shared.Domain.Repositories;

namespace CatchUpPlatform.API.News.Application.Internal.CommandServices;

/// <summary>
///     Favorite source command service.
/// </summary>
/// <remarks>
///     This class implements the basic operations for a favorite source command service.
/// </remarks>
/// <param name="favoriteSourceRepository">The instance of FavoriteSourceRepository</param>
/// <param name="unitOfWork">The instance of UnitOfWork</param>
/// See
/// <see cref="IFavoriteSourceRepository">IFavoriteSourceRepository</see>
/// ,
/// <see cref="IUnitOfWork">IUnitOfWork</see>
public class FavoriteSourceCommandService(IFavoriteSourceRepository favoriteSourceRepository, IUnitOfWork unitOfWork)
    : IFavoriteSourceCommandService
{
    /// <inheritdoc />
    public async Task<FavoriteSource?> Handle(CreateFavoriteSourceCommand command)
    {
        var favoriteSource =
            await favoriteSourceRepository.FindByNewsApiKeyAndSourceIdAsync(command.NewsApiKey, command.SourceId);
        if (favoriteSource != null)
            throw new Exception("Favorite source with this SourceId already exists for the given NewsApiKey");
        favoriteSource = new FavoriteSource(command);
        try
        {
            await favoriteSourceRepository.AddAsync(favoriteSource);
            await unitOfWork.CompleteAsync();
        }
        catch (Exception e)
        {
            return null;
        }

        return favoriteSource;
    }
}