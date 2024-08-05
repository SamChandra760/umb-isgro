using System.Globalization;
using System.Text;
using DocumentFormat.OpenXml.Spreadsheet;
using J2N.Text;
using Microsoft.Extensions.Primitives;
using isgro.Enumerations;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace isgro.Helpers;

public static class BlockGridSettingsHelper
{

    public static string? ParseVerticalAlignment(this IAlignmentSettings? settings)
    {
        if (settings is null)
        {
            return null;
        }
        return settings?.VerticalAlignment switch
        {
            "" => null,
            "oben" => "h-100 align-content-start",
            "mitte" => "h-100 align-content-center",
            "unten" => "h-100 align-content-end",
            _ => null,
        };
    }

    public static string? ParseVisibilitySettings(this IVisibilitySettings? settings, DisplayType displayType)
    {
        if (settings is null)
        {
            return null;
        }

        int visibilityValue = Convert.ToInt32($"{(settings.VisibilityDesktop ? 1 : 0)}" +
                                              $"{(settings.VisibilityTablet ? 1 : 0)}" +
                                              $"{(settings.VisibilityMobile ? 1 : 0)}", 2);

        string displayTypeValue = displayType.ToString().ToLower();

        return visibilityValue switch
        {
            7 => null,
            6 => $"d-none d-sm-{displayTypeValue}",
            5 => $"d-{displayTypeValue} d-md-none d-lg-{displayTypeValue}",
            4 => $"d-none d-lg-{displayTypeValue}",
            3 => $"d-{displayTypeValue} d-lg-none",
            2 => $"d-none d-md-{displayTypeValue} d-lg-none",
            1 => $"d-{displayTypeValue} d-md-none",
            0 => "d-none",
            _ => null,
        };
    }

    public static string? ParseSpacingSettings(this IPublishedElement settings)
    {
        if (settings is not IGapSettings gapSettings)
        {
            return null;
        }

        return $"pt-{gapSettings.PtSM} pt-md-{gapSettings.PtMD} pt-lg-{gapSettings.Pt} " +
               $"pb-{gapSettings.PbSM} pb-md-{gapSettings.PbMD} pb-lg-{gapSettings.Pb} " +
               $"ps-{gapSettings.PsSM} ps-md-{gapSettings.PsMD} ps-lg-{gapSettings.Ps} " +
               $"pe-{gapSettings.PeSM} pe-md-{gapSettings.PeMD} pe-lg-{gapSettings.Pe} " +
               $"mt-{gapSettings.MtSM} mt-md-{gapSettings.MtMD} mt-lg-{gapSettings.Mt} " +
               $"mb-{gapSettings.MbSM} mb-md-{gapSettings.MbMD} mb-lg-{gapSettings.Mb} " +
               $"ms-{gapSettings.MsSM} ms-md-{gapSettings.MsMD} ms-lg-{gapSettings.Ms} " +
               $"me-{gapSettings.MeSM} me-md-{gapSettings.MeMD} me-lg-{gapSettings.Me}";
    }

    public static string? ParseBackgroundSettings(this IPublishedElement? settings)
    {
        if (settings is not IColorSettings colorSettings)
        {
            return string.Empty;
        }

        var sb = new StringBuilder();

        if (!string.IsNullOrEmpty(colorSettings.BackgroundColor))
        {
            sb.Append($"--nwb-section-background-color: {colorSettings.BackgroundColor};");
        }

        if (colorSettings.BackgroundImage is not null)
        {
            sb.Append($"--nwb-section-background-image: url('{colorSettings.BackgroundImage.Url()}');");
        }
        
        return sb.Length == 0 ? null : sb.ToString();
    }
    
    //public static string? GetHeadlineSizes(this Headline? headline)
    //{
    //    if (headline is null)
    //    {
    //        return null;
    //    }

    //    var type = headline.HeadlineType.ToString().ToLower();
    //    var builder = new StringBuilder();

    //    if (headline.FontSizeXxl != 0)
    //    {
    //        builder.Append($"--nwb-heading-font-size-xxl-{type}: {headline.FontSizeXxl}px; ");
    //    }

    //    if (headline.FontSizeXL != 0)
    //    {
    //        builder.Append($"--nwb-heading-font-size-xl-{type}: {headline.FontSizeXL}px; ");
    //    }

    //    if (headline.FontSizeLG != 0)
    //    {
    //        builder.Append($"--nwb-heading-font-size-lg-{type}: {headline.FontSizeLG}px; ");
    //    }

    //    if (headline.FontSize != 0)
    //    {
    //        builder.Append($"--nwb-heading-font-size-{type}: {headline.FontSize}px; ");
    //    }


    //    return builder.ToString().Trim();
    //}

    public static string? GetTextAlignment(TextAlign? textAlign) => textAlign switch
    {
        TextAlign.Left => "text-start",
        TextAlign.Center => "text-center",
        TextAlign.Right => "text-end",
        _ => null,
    };

    //public static string ParseHeadlineStyle(this Headline headline)
    //{
    //    FontWeight fontWeight = headline.FontWeight == 0 ? FontWeight.Medium : headline.FontWeight;
    //    string color = string.IsNullOrEmpty(headline.Color) ? "#000" : headline.Color;
    //    string letterSpacing = headline.LetterSpacing == 0 ? "0px" : $"{headline.LetterSpacing}px";
    //    var lineHeight = headline.LineHeight == 0 ? 1.1m : headline.LineHeight;

    //    var sb = new StringBuilder();
    //    sb.Append($"--nwb-heading-font-weight: {(int)fontWeight}; ");
    //    sb.Append($"--nwb-heading-font-color: {color}; ");
    //    sb.Append($"--nwb-heading-letter-spacing: {letterSpacing}; ");
    //    sb.Append($"--nwb-heading-line-height: {lineHeight.ToString("F", CultureInfo.InvariantCulture)}");

    //    return sb.ToString();
    //}
}