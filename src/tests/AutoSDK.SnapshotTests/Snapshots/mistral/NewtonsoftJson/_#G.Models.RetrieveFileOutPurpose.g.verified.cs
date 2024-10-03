//HintName: G.Models.RetrieveFileOutPurpose.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The intended purpose of the uploaded file. Only accepts fine-tuning (`fine-tune`) for now.<br/>
    /// Example: fine-tune
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RetrieveFileOutPurpose
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fine-tune")]
        FineTune,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetrieveFileOutPurposeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetrieveFileOutPurpose value)
        {
            return value switch
            {
                RetrieveFileOutPurpose.FineTune => "fine-tune",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetrieveFileOutPurpose? ToEnum(string value)
        {
            return value switch
            {
                "fine-tune" => RetrieveFileOutPurpose.FineTune,
                _ => null,
            };
        }
    }
}