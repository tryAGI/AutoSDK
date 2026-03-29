//HintName: G.Models.ConfiguredRulesDatesAndTimes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConfiguredRulesDatesAndTimes
    {
        /// <summary>
        /// Formatting options for Calendar Era
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calendar_era")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesDatesAndTimesCalendarEraJsonConverter))]
        public global::G.ConfiguredRulesDatesAndTimesCalendarEra? CalendarEra { get; set; }

        /// <summary>
        /// Formatting options for Centuries
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("centuries")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesDatesAndTimesCenturiesJsonConverter))]
        public global::G.ConfiguredRulesDatesAndTimesCenturies? Centuries { get; set; }

        /// <summary>
        /// Formatting options for Date Format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesDatesAndTimesDateFormatJsonConverter))]
        public global::G.ConfiguredRulesDatesAndTimesDateFormat? DateFormat { get; set; }

        /// <summary>
        /// Formatting options for Dates In Numerical Form
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dates_in_numerical_form")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesDatesAndTimesDatesInNumericalFormJsonConverter))]
        public global::G.ConfiguredRulesDatesAndTimesDatesInNumericalForm? DatesInNumericalForm { get; set; }

        /// <summary>
        /// Formatting options for Decades
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decades")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesDatesAndTimesDecadesJsonConverter))]
        public global::G.ConfiguredRulesDatesAndTimesDecades? Decades { get; set; }

        /// <summary>
        /// Formatting options for Hours Minutes Seconds Separator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hours_minutes_seconds_separator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesDatesAndTimesHoursMinutesSecondsSeparatorJsonConverter))]
        public global::G.ConfiguredRulesDatesAndTimesHoursMinutesSecondsSeparator? HoursMinutesSecondsSeparator { get; set; }

        /// <summary>
        /// Formatting options for Hours Minutes Separator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hours_minutes_separator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesDatesAndTimesHoursMinutesSeparatorJsonConverter))]
        public global::G.ConfiguredRulesDatesAndTimesHoursMinutesSeparator? HoursMinutesSeparator { get; set; }

        /// <summary>
        /// Formatting options for Midnight In Numerals
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("midnight_in_numerals")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesDatesAndTimesMidnightInNumeralsJsonConverter))]
        public global::G.ConfiguredRulesDatesAndTimesMidnightInNumerals? MidnightInNumerals { get; set; }

        /// <summary>
        /// Formatting options for Single Digit Days And Months
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("single_digit_days_and_months")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesDatesAndTimesSingleDigitDaysAndMonthsJsonConverter))]
        public global::G.ConfiguredRulesDatesAndTimesSingleDigitDaysAndMonths? SingleDigitDaysAndMonths { get; set; }

        /// <summary>
        /// Formatting options for Single Digit Hours
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("single_digit_hours")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesDatesAndTimesSingleDigitHoursJsonConverter))]
        public global::G.ConfiguredRulesDatesAndTimesSingleDigitHours? SingleDigitHours { get; set; }

        /// <summary>
        /// Formatting options for Time Format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesDatesAndTimesTimeFormatJsonConverter))]
        public global::G.ConfiguredRulesDatesAndTimesTimeFormat? TimeFormat { get; set; }

        /// <summary>
        /// Formatting options for Writing Dates
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("writing_dates")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesDatesAndTimesWritingDatesJsonConverter))]
        public global::G.ConfiguredRulesDatesAndTimesWritingDates? WritingDates { get; set; }

        /// <summary>
        /// Formatting options for Years
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("years")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesDatesAndTimesYearsJsonConverter))]
        public global::G.ConfiguredRulesDatesAndTimesYears? Years { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfiguredRulesDatesAndTimes" /> class.
        /// </summary>
        /// <param name="calendarEra">
        /// Formatting options for Calendar Era
        /// </param>
        /// <param name="centuries">
        /// Formatting options for Centuries
        /// </param>
        /// <param name="dateFormat">
        /// Formatting options for Date Format
        /// </param>
        /// <param name="datesInNumericalForm">
        /// Formatting options for Dates In Numerical Form
        /// </param>
        /// <param name="decades">
        /// Formatting options for Decades
        /// </param>
        /// <param name="hoursMinutesSecondsSeparator">
        /// Formatting options for Hours Minutes Seconds Separator
        /// </param>
        /// <param name="hoursMinutesSeparator">
        /// Formatting options for Hours Minutes Separator
        /// </param>
        /// <param name="midnightInNumerals">
        /// Formatting options for Midnight In Numerals
        /// </param>
        /// <param name="singleDigitDaysAndMonths">
        /// Formatting options for Single Digit Days And Months
        /// </param>
        /// <param name="singleDigitHours">
        /// Formatting options for Single Digit Hours
        /// </param>
        /// <param name="timeFormat">
        /// Formatting options for Time Format
        /// </param>
        /// <param name="writingDates">
        /// Formatting options for Writing Dates
        /// </param>
        /// <param name="years">
        /// Formatting options for Years
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConfiguredRulesDatesAndTimes(
            global::G.ConfiguredRulesDatesAndTimesCalendarEra? calendarEra,
            global::G.ConfiguredRulesDatesAndTimesCenturies? centuries,
            global::G.ConfiguredRulesDatesAndTimesDateFormat? dateFormat,
            global::G.ConfiguredRulesDatesAndTimesDatesInNumericalForm? datesInNumericalForm,
            global::G.ConfiguredRulesDatesAndTimesDecades? decades,
            global::G.ConfiguredRulesDatesAndTimesHoursMinutesSecondsSeparator? hoursMinutesSecondsSeparator,
            global::G.ConfiguredRulesDatesAndTimesHoursMinutesSeparator? hoursMinutesSeparator,
            global::G.ConfiguredRulesDatesAndTimesMidnightInNumerals? midnightInNumerals,
            global::G.ConfiguredRulesDatesAndTimesSingleDigitDaysAndMonths? singleDigitDaysAndMonths,
            global::G.ConfiguredRulesDatesAndTimesSingleDigitHours? singleDigitHours,
            global::G.ConfiguredRulesDatesAndTimesTimeFormat? timeFormat,
            global::G.ConfiguredRulesDatesAndTimesWritingDates? writingDates,
            global::G.ConfiguredRulesDatesAndTimesYears? years)
        {
            this.CalendarEra = calendarEra;
            this.Centuries = centuries;
            this.DateFormat = dateFormat;
            this.DatesInNumericalForm = datesInNumericalForm;
            this.Decades = decades;
            this.HoursMinutesSecondsSeparator = hoursMinutesSecondsSeparator;
            this.HoursMinutesSeparator = hoursMinutesSeparator;
            this.MidnightInNumerals = midnightInNumerals;
            this.SingleDigitDaysAndMonths = singleDigitDaysAndMonths;
            this.SingleDigitHours = singleDigitHours;
            this.TimeFormat = timeFormat;
            this.WritingDates = writingDates;
            this.Years = years;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfiguredRulesDatesAndTimes" /> class.
        /// </summary>
        public ConfiguredRulesDatesAndTimes()
        {
        }
    }
}