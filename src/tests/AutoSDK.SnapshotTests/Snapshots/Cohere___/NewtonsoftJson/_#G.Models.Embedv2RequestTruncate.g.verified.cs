//HintName: G.Models.Embedv2RequestTruncate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// One of `NONE|START|END` to specify how the API will handle inputs longer than the maximum token length.<br/>
    /// Passing `START` will discard the start of the input. `END` will discard the end of the input. In both cases, input is discarded until the remaining input is exactly the maximum input token length for the model.<br/>
    /// If `NONE` is selected, when the input exceeds the maximum input token length an error will be returned.<br/>
    /// Default Value: END<br/>
    /// Included only in requests
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Embedv2RequestTruncate
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
    public static class Embedv2RequestTruncateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Embedv2RequestTruncate value)
        {
            return value switch
            {
                Embedv2RequestTruncate.NONE => "NONE",
                Embedv2RequestTruncate.START => "START",
                Embedv2RequestTruncate.END => "END",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Embedv2RequestTruncate? ToEnum(string value)
        {
            return value switch
            {
                "NONE" => Embedv2RequestTruncate.NONE,
                "START" => Embedv2RequestTruncate.START,
                "END" => Embedv2RequestTruncate.END,
                _ => null,
            };
        }
    }
}