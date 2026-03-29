//HintName: G.Models.RecognitionDisplayDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RecognitionDisplayDirection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ltr")]
        Ltr,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rtl")]
        Rtl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RecognitionDisplayDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RecognitionDisplayDirection value)
        {
            return value switch
            {
                RecognitionDisplayDirection.Ltr => "ltr",
                RecognitionDisplayDirection.Rtl => "rtl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RecognitionDisplayDirection? ToEnum(string value)
        {
            return value switch
            {
                "ltr" => RecognitionDisplayDirection.Ltr,
                "rtl" => RecognitionDisplayDirection.Rtl,
                _ => null,
            };
        }
    }
}