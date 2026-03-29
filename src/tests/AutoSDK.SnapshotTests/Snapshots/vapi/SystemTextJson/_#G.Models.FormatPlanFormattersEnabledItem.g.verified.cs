//HintName: G.Models.FormatPlanFormattersEnabledItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FormatPlanFormattersEnabledItem
    {
        /// <summary>
        /// 
        /// </summary>
        Acronym,
        /// <summary>
        /// 
        /// </summary>
        Asterisk,
        /// <summary>
        /// 
        /// </summary>
        Colon,
        /// <summary>
        /// 
        /// </summary>
        Dash,
        /// <summary>
        /// 
        /// </summary>
        Date,
        /// <summary>
        /// 
        /// </summary>
        Distance,
        /// <summary>
        /// 
        /// </summary>
        DollarAmount,
        /// <summary>
        /// 
        /// </summary>
        Email,
        /// <summary>
        /// 
        /// </summary>
        Markdown,
        /// <summary>
        /// 
        /// </summary>
        Newline,
        /// <summary>
        /// 
        /// </summary>
        Number,
        /// <summary>
        /// 
        /// </summary>
        Percentage,
        /// <summary>
        /// 
        /// </summary>
        PhoneNumber,
        /// <summary>
        /// 
        /// </summary>
        Quote,
        /// <summary>
        /// 
        /// </summary>
        StripAsterisk,
        /// <summary>
        /// 
        /// </summary>
        Time,
        /// <summary>
        /// 
        /// </summary>
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