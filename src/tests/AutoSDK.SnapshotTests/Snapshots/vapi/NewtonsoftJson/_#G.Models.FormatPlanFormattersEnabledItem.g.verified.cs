//HintName: G.Models.FormatPlanFormattersEnabledItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FormatPlanFormattersEnabledItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="acronym")]
        Acronym,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="asterisk")]
        Asterisk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="colon")]
        Colon,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dash")]
        Dash,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="date")]
        Date,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="distance")]
        Distance,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dollarAmount")]
        DollarAmount,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="email")]
        Email,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="markdown")]
        Markdown,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="newline")]
        Newline,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="number")]
        Number,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="percentage")]
        Percentage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="phoneNumber")]
        PhoneNumber,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="quote")]
        Quote,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stripAsterisk")]
        StripAsterisk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="time")]
        Time,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unit")]
        Unit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FormatPlanFormattersEnabledItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FormatPlanFormattersEnabledItem value)
        {
            return value switch
            {
                FormatPlanFormattersEnabledItem.Acronym => "acronym",
                FormatPlanFormattersEnabledItem.Asterisk => "asterisk",
                FormatPlanFormattersEnabledItem.Colon => "colon",
                FormatPlanFormattersEnabledItem.Dash => "dash",
                FormatPlanFormattersEnabledItem.Date => "date",
                FormatPlanFormattersEnabledItem.Distance => "distance",
                FormatPlanFormattersEnabledItem.DollarAmount => "dollarAmount",
                FormatPlanFormattersEnabledItem.Email => "email",
                FormatPlanFormattersEnabledItem.Markdown => "markdown",
                FormatPlanFormattersEnabledItem.Newline => "newline",
                FormatPlanFormattersEnabledItem.Number => "number",
                FormatPlanFormattersEnabledItem.Percentage => "percentage",
                FormatPlanFormattersEnabledItem.PhoneNumber => "phoneNumber",
                FormatPlanFormattersEnabledItem.Quote => "quote",
                FormatPlanFormattersEnabledItem.StripAsterisk => "stripAsterisk",
                FormatPlanFormattersEnabledItem.Time => "time",
                FormatPlanFormattersEnabledItem.Unit => "unit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FormatPlanFormattersEnabledItem? ToEnum(string value)
        {
            return value switch
            {
                "acronym" => FormatPlanFormattersEnabledItem.Acronym,
                "asterisk" => FormatPlanFormattersEnabledItem.Asterisk,
                "colon" => FormatPlanFormattersEnabledItem.Colon,
                "dash" => FormatPlanFormattersEnabledItem.Dash,
                "date" => FormatPlanFormattersEnabledItem.Date,
                "distance" => FormatPlanFormattersEnabledItem.Distance,
                "dollarAmount" => FormatPlanFormattersEnabledItem.DollarAmount,
                "email" => FormatPlanFormattersEnabledItem.Email,
                "markdown" => FormatPlanFormattersEnabledItem.Markdown,
                "newline" => FormatPlanFormattersEnabledItem.Newline,
                "number" => FormatPlanFormattersEnabledItem.Number,
                "percentage" => FormatPlanFormattersEnabledItem.Percentage,
                "phoneNumber" => FormatPlanFormattersEnabledItem.PhoneNumber,
                "quote" => FormatPlanFormattersEnabledItem.Quote,
                "stripAsterisk" => FormatPlanFormattersEnabledItem.StripAsterisk,
                "time" => FormatPlanFormattersEnabledItem.Time,
                "unit" => FormatPlanFormattersEnabledItem.Unit,
                _ => null,
            };
        }
    }
}