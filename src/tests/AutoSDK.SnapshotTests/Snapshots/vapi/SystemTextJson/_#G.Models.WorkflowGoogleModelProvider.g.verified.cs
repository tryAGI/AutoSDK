//HintName: G.Models.WorkflowGoogleModelProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the provider of the model (`google`).
    /// </summary>
    public enum WorkflowGoogleModelProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Google,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowGoogleModelProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowGoogleModelProvider value)
        {
            return value switch
            {
                WorkflowGoogleModelProvider.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowGoogleModelProvider? ToEnum(string value)
        {
            return value switch
            {
                "google" => WorkflowGoogleModelProvider.Google,
                _ => null,
            };
        }
    }
}