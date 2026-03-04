//HintName: G.Models.CreateEmbedJobRequestTruncate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// One of `START|END` to specify how the API will handle inputs longer than the maximum token length.<br/>
    /// Passing `START` will discard the start of the input. `END` will discard the end of the input. In both cases, input is discarded until the remaining input is exactly the maximum input token length for the model.<br/>
    /// Default Value: END
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateEmbedJobRequestTruncate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="START")]
        Start,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="END")]
        End,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEmbedJobRequestTruncateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEmbedJobRequestTruncate value)
        {
            return value switch
            {
                CreateEmbedJobRequestTruncate.Start => "START",
                CreateEmbedJobRequestTruncate.End => "END",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEmbedJobRequestTruncate? ToEnum(string value)
        {
            return value switch
            {
                "START" => CreateEmbedJobRequestTruncate.Start,
                "END" => CreateEmbedJobRequestTruncate.End,
                _ => null,
            };
        }
    }
}