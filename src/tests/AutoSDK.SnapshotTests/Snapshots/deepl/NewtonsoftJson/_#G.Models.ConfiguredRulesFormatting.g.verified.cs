//HintName: G.Models.ConfiguredRulesFormatting.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConfiguredRulesFormatting
    {
        /// <summary>
        /// Formatting options for Email Address Format
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email_address_format")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesFormattingEmailAddressFormatJsonConverter))]
        public global::G.ConfiguredRulesFormattingEmailAddressFormat? EmailAddressFormat { get; set; }

        /// <summary>
        /// Formatting options for Phone Number Country Code Format
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phone_number_country_code_format")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesFormattingPhoneNumberCountryCodeFormatJsonConverter))]
        public global::G.ConfiguredRulesFormattingPhoneNumberCountryCodeFormat? PhoneNumberCountryCodeFormat { get; set; }

        /// <summary>
        /// Formatting options for Phone Number Format
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phone_number_format")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesFormattingPhoneNumberFormatJsonConverter))]
        public global::G.ConfiguredRulesFormattingPhoneNumberFormat? PhoneNumberFormat { get; set; }

        /// <summary>
        /// Formatting options for Space Between Arabic Numerals And Unit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("space_between_arabic_numerals_and_unit")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesFormattingSpaceBetweenArabicNumeralsAndUnitJsonConverter))]
        public global::G.ConfiguredRulesFormattingSpaceBetweenArabicNumeralsAndUnit? SpaceBetweenArabicNumeralsAndUnit { get; set; }

        /// <summary>
        /// Formatting options for Space Between Chinese And English
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("space_between_chinese_and_english")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesFormattingSpaceBetweenChineseAndEnglishJsonConverter))]
        public global::G.ConfiguredRulesFormattingSpaceBetweenChineseAndEnglish? SpaceBetweenChineseAndEnglish { get; set; }

        /// <summary>
        /// Formatting options for Space Between Chinese Characters And Arabic Numerals
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("space_between_chinese_characters_and_arabic_numerals")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesFormattingSpaceBetweenChineseCharactersAndArabicNumeralsJsonConverter))]
        public global::G.ConfiguredRulesFormattingSpaceBetweenChineseCharactersAndArabicNumerals? SpaceBetweenChineseCharactersAndArabicNumerals { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfiguredRulesFormatting" /> class.
        /// </summary>
        /// <param name="emailAddressFormat">
        /// Formatting options for Email Address Format
        /// </param>
        /// <param name="phoneNumberCountryCodeFormat">
        /// Formatting options for Phone Number Country Code Format
        /// </param>
        /// <param name="phoneNumberFormat">
        /// Formatting options for Phone Number Format
        /// </param>
        /// <param name="spaceBetweenArabicNumeralsAndUnit">
        /// Formatting options for Space Between Arabic Numerals And Unit
        /// </param>
        /// <param name="spaceBetweenChineseAndEnglish">
        /// Formatting options for Space Between Chinese And English
        /// </param>
        /// <param name="spaceBetweenChineseCharactersAndArabicNumerals">
        /// Formatting options for Space Between Chinese Characters And Arabic Numerals
        /// </param>
        public ConfiguredRulesFormatting(
            global::G.ConfiguredRulesFormattingEmailAddressFormat? emailAddressFormat,
            global::G.ConfiguredRulesFormattingPhoneNumberCountryCodeFormat? phoneNumberCountryCodeFormat,
            global::G.ConfiguredRulesFormattingPhoneNumberFormat? phoneNumberFormat,
            global::G.ConfiguredRulesFormattingSpaceBetweenArabicNumeralsAndUnit? spaceBetweenArabicNumeralsAndUnit,
            global::G.ConfiguredRulesFormattingSpaceBetweenChineseAndEnglish? spaceBetweenChineseAndEnglish,
            global::G.ConfiguredRulesFormattingSpaceBetweenChineseCharactersAndArabicNumerals? spaceBetweenChineseCharactersAndArabicNumerals)
        {
            this.EmailAddressFormat = emailAddressFormat;
            this.PhoneNumberCountryCodeFormat = phoneNumberCountryCodeFormat;
            this.PhoneNumberFormat = phoneNumberFormat;
            this.SpaceBetweenArabicNumeralsAndUnit = spaceBetweenArabicNumeralsAndUnit;
            this.SpaceBetweenChineseAndEnglish = spaceBetweenChineseAndEnglish;
            this.SpaceBetweenChineseCharactersAndArabicNumerals = spaceBetweenChineseCharactersAndArabicNumerals;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfiguredRulesFormatting" /> class.
        /// </summary>
        public ConfiguredRulesFormatting()
        {
        }
    }
}