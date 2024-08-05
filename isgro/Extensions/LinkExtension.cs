using Umbraco.Cms.Core.Models;

namespace isgro.Extensions;

public static class LinkExtension
{
    /// <summary>
    /// Returns the URL with protocol.
    /// </summary>
    /// <param name="link">The link object.</param>
    /// <returns>The URL with protocol.</returns>
    public static string? GetUrlWithProtocol(this Link link)
    {
        if (string.IsNullOrEmpty(link.Url))
        {
            return null;
        }

        return link.Url.StartsWith("http://") || link.Url.StartsWith("https://") ? link.Url : $"https://{link.Url}";
    }

    /// <summary>
    /// Replaces the protocol of a given URL by removing "https://www." and "https://"
    /// </summary>
    /// <param name="link">The link to replace the protocol.</param>
    /// <returns>The modified URL with the protocol replaced.</returns>
    public static string? ReplaceProtocol(this Link link)
    {
        return string.IsNullOrEmpty(link.Url)
            ? null
            : link.Url.Replace("https://www.", string.Empty).Replace("https://", string.Empty);
    }
}