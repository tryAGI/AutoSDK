//HintName: G.Models.CompletionJobOutObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type of the fine-tuning job.<br/>
    /// Default Value: job
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CompletionJobOutObject
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
    public static class CompletionJobOutObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionJobOutObject value)
        {
            return value switch
            {
                CompletionJobOutObject.Job => "job",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionJobOutObject? ToEnum(string value)
        {
            return value switch
            {
                "job" => CompletionJobOutObject.Job,
                _ => null,
            };
        }
    }
}