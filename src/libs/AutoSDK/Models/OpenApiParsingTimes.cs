namespace AutoSDK.Models;

public record struct OpenApiParsingTimes(
    TimeSpan JsonSyntax,
    TimeSpan CompatibilityNormalization,
    TimeSpan MicrosoftReader,
    TimeSpan CompatibilityWalker,
    TimeSpan PostProcessing,
    long AllocJsonSyntax = 0,
    long AllocCompatibilityNormalization = 0,
    long AllocMicrosoftReader = 0,
    long AllocCompatibilityWalker = 0,
    long AllocPostProcessing = 0)
{
    public static OpenApiParsingTimes operator +(
        OpenApiParsingTimes left,
        OpenApiParsingTimes right)
    {
        return Add(left, right);
    }

    public static OpenApiParsingTimes Add(
        OpenApiParsingTimes left,
        OpenApiParsingTimes right)
    {
        return new OpenApiParsingTimes(
            JsonSyntax: left.JsonSyntax + right.JsonSyntax,
            CompatibilityNormalization: left.CompatibilityNormalization + right.CompatibilityNormalization,
            MicrosoftReader: left.MicrosoftReader + right.MicrosoftReader,
            CompatibilityWalker: left.CompatibilityWalker + right.CompatibilityWalker,
            PostProcessing: left.PostProcessing + right.PostProcessing,
            AllocJsonSyntax: left.AllocJsonSyntax + right.AllocJsonSyntax,
            AllocCompatibilityNormalization: left.AllocCompatibilityNormalization + right.AllocCompatibilityNormalization,
            AllocMicrosoftReader: left.AllocMicrosoftReader + right.AllocMicrosoftReader,
            AllocCompatibilityWalker: left.AllocCompatibilityWalker + right.AllocCompatibilityWalker,
            AllocPostProcessing: left.AllocPostProcessing + right.AllocPostProcessing);
    }
}
