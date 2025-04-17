//HintName: G.Models.CompletionDetailedJobOutObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: job
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CompletionDetailedJobOutObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="job")]
        Job,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompletionDetailedJobOutObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionDetailedJobOutObject value)
        {
            return value switch
            {
                CompletionDetailedJobOutObject.Job => "job",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionDetailedJobOutObject? ToEnum(string value)
        {
            return value switch
            {
                "job" => CompletionDetailedJobOutObject.Job,
                _ => null,
            };
        }
    }
}