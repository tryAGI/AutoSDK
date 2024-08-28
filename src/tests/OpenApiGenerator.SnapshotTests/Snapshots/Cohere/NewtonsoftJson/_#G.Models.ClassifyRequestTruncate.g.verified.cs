//HintName: G.Models.ClassifyRequestTruncate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// One of `NONE|START|END` to specify how the API will handle inputs longer than the maximum token length.<br/>
    /// Passing `START` will discard the start of the input. `END` will discard the end of the input. In both cases, input is discarded until the remaining input is exactly the maximum input token length for the model.<br/>
    /// If `NONE` is selected, when the input exceeds the maximum input token length an error will be returned.<br/>
    /// Default Value: END
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClassifyRequestTruncate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NONE")]
        NONE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="START")]
        START,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="END")]
        END,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClassifyRequestTruncateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClassifyRequestTruncate value)
        {
            return value switch
            {
                ClassifyRequestTruncate.NONE => "NONE",
                ClassifyRequestTruncate.START => "START",
                ClassifyRequestTruncate.END => "END",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClassifyRequestTruncate? ToEnum(string value)
        {
            return value switch
            {
                "NONE" => ClassifyRequestTruncate.NONE,
                "START" => ClassifyRequestTruncate.START,
                "END" => ClassifyRequestTruncate.END,
                _ => null,
            };
        }
    }
}