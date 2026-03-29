//HintName: G.Models.EvalGoogleModelProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the provider of the model (`google`).
    /// </summary>
    public enum EvalGoogleModelProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Google,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalGoogleModelProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalGoogleModelProvider value)
        {
            return value switch
            {
                EvalGoogleModelProvider.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalGoogleModelProvider? ToEnum(string value)
        {
            return value switch
            {
                "google" => EvalGoogleModelProvider.Google,
                _ => null,
            };
        }
    }
}