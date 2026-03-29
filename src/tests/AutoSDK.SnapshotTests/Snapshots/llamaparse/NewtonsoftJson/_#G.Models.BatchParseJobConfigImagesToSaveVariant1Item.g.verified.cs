//HintName: G.Models.BatchParseJobConfigImagesToSaveVariant1Item.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BatchParseJobConfigImagesToSaveVariant1Item
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="embedded")]
        Embedded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="layout")]
        Layout,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="screenshot")]
        Screenshot,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchParseJobConfigImagesToSaveVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchParseJobConfigImagesToSaveVariant1Item value)
        {
            return value switch
            {
                BatchParseJobConfigImagesToSaveVariant1Item.Embedded => "embedded",
                BatchParseJobConfigImagesToSaveVariant1Item.Layout => "layout",
                BatchParseJobConfigImagesToSaveVariant1Item.Screenshot => "screenshot",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchParseJobConfigImagesToSaveVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "embedded" => BatchParseJobConfigImagesToSaveVariant1Item.Embedded,
                "layout" => BatchParseJobConfigImagesToSaveVariant1Item.Layout,
                "screenshot" => BatchParseJobConfigImagesToSaveVariant1Item.Screenshot,
                _ => null,
            };
        }
    }
}