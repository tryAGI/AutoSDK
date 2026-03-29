//HintName: G.Models.ConfiguredRulesNumbers.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConfiguredRulesNumbers
    {
        /// <summary>
        /// Formatting options for Approximate Numbers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approximate_numbers")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesNumbersApproximateNumbersJsonConverter))]
        public global::G.ConfiguredRulesNumbersApproximateNumbers? ApproximateNumbers { get; set; }

        /// <summary>
        /// Formatting options for Currency Format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesNumbersCurrencyFormatJsonConverter))]
        public global::G.ConfiguredRulesNumbersCurrencyFormat? CurrencyFormat { get; set; }

        /// <summary>
        /// Formatting options for Decimal Numbers Less Than One
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decimal_numbers_less_than_one")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesNumbersDecimalNumbersLessThanOneJsonConverter))]
        public global::G.ConfiguredRulesNumbersDecimalNumbersLessThanOne? DecimalNumbersLessThanOne { get; set; }

        /// <summary>
        /// Formatting options for Decimal Separator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decimal_separator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesNumbersDecimalSeparatorJsonConverter))]
        public global::G.ConfiguredRulesNumbersDecimalSeparator? DecimalSeparator { get; set; }

        /// <summary>
        /// Formatting options for Dimensions Separator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensions_separator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesNumbersDimensionsSeparatorJsonConverter))]
        public global::G.ConfiguredRulesNumbersDimensionsSeparator? DimensionsSeparator { get; set; }

        /// <summary>
        /// Formatting options for Equation Formula Reference
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("equation_formula_reference")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesNumbersEquationFormulaReferenceJsonConverter))]
        public global::G.ConfiguredRulesNumbersEquationFormulaReference? EquationFormulaReference { get; set; }

        /// <summary>
        /// Formatting options for Kanji Numbers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kanji_numbers")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesNumbersKanjiNumbersJsonConverter))]
        public global::G.ConfiguredRulesNumbersKanjiNumbers? KanjiNumbers { get; set; }

        /// <summary>
        /// Formatting options for Large Number Format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("large_number_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesNumbersLargeNumberFormatJsonConverter))]
        public global::G.ConfiguredRulesNumbersLargeNumberFormat? LargeNumberFormat { get; set; }

        /// <summary>
        /// Formatting options for Large Sums Of Money
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("large_sums_of_money")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesNumbersLargeSumsOfMoneyJsonConverter))]
        public global::G.ConfiguredRulesNumbersLargeSumsOfMoney? LargeSumsOfMoney { get; set; }

        /// <summary>
        /// Formatting options for Large Sums Of Money Format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("large_sums_of_money_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesNumbersLargeSumsOfMoneyFormatJsonConverter))]
        public global::G.ConfiguredRulesNumbersLargeSumsOfMoneyFormat? LargeSumsOfMoneyFormat { get; set; }

        /// <summary>
        /// Formatting options for List Of Measurements With Units
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("list_of_measurements_with_units")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesNumbersListOfMeasurementsWithUnitsJsonConverter))]
        public global::G.ConfiguredRulesNumbersListOfMeasurementsWithUnits? ListOfMeasurementsWithUnits { get; set; }

        /// <summary>
        /// Formatting options for Mathematical Expression Spacing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mathematical_expression_spacing")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesNumbersMathematicalExpressionSpacingJsonConverter))]
        public global::G.ConfiguredRulesNumbersMathematicalExpressionSpacing? MathematicalExpressionSpacing { get; set; }

        /// <summary>
        /// Formatting options for Number Format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesNumbersNumberFormatJsonConverter))]
        public global::G.ConfiguredRulesNumbersNumberFormat? NumberFormat { get; set; }

        /// <summary>
        /// Formatting options for Number Separator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number_separator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesNumbersNumberSeparatorJsonConverter))]
        public global::G.ConfiguredRulesNumbersNumberSeparator? NumberSeparator { get; set; }

        /// <summary>
        /// Formatting options for Numbers Of 5 Digits Or More
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numbers_of_5_digits_or_more")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesNumbersNumbersOf5DigitsOrMoreJsonConverter))]
        public global::G.ConfiguredRulesNumbersNumbersOf5DigitsOrMore? NumbersOf5DigitsOrMore { get; set; }

        /// <summary>
        /// Formatting options for Numbers Up To 4 Digits
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numbers_up_to_4_digits")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesNumbersNumbersUpTo4DigitsJsonConverter))]
        public global::G.ConfiguredRulesNumbersNumbersUpTo4Digits? NumbersUpTo4Digits { get; set; }

        /// <summary>
        /// Formatting options for Percentage Format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percentage_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesNumbersPercentageFormatJsonConverter))]
        public global::G.ConfiguredRulesNumbersPercentageFormat? PercentageFormat { get; set; }

        /// <summary>
        /// Formatting options for Reference To Symbol
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_to_symbol")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesNumbersReferenceToSymbolJsonConverter))]
        public global::G.ConfiguredRulesNumbersReferenceToSymbol? ReferenceToSymbol { get; set; }

        /// <summary>
        /// Formatting options for Spelling Out Units
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spelling_out_units")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesNumbersSpellingOutUnitsJsonConverter))]
        public global::G.ConfiguredRulesNumbersSpellingOutUnits? SpellingOutUnits { get; set; }

        /// <summary>
        /// Formatting options for Temperature Format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesNumbersTemperatureFormatJsonConverter))]
        public global::G.ConfiguredRulesNumbersTemperatureFormat? TemperatureFormat { get; set; }

        /// <summary>
        /// Formatting options for Thousands Separator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thousands_separator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesNumbersThousandsSeparatorJsonConverter))]
        public global::G.ConfiguredRulesNumbersThousandsSeparator? ThousandsSeparator { get; set; }

        /// <summary>
        /// Formatting options for Units Of Measure Spacing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("units_of_measure_spacing")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesNumbersUnitsOfMeasureSpacingJsonConverter))]
        public global::G.ConfiguredRulesNumbersUnitsOfMeasureSpacing? UnitsOfMeasureSpacing { get; set; }

        /// <summary>
        /// Formatting options for Use Of Hiragana And Kanji
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_of_hiragana_and_kanji")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesNumbersUseOfHiraganaAndKanjiJsonConverter))]
        public global::G.ConfiguredRulesNumbersUseOfHiraganaAndKanji? UseOfHiraganaAndKanji { get; set; }

        /// <summary>
        /// Formatting options for Writing Numbers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("writing_numbers")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesNumbersWritingNumbersJsonConverter))]
        public global::G.ConfiguredRulesNumbersWritingNumbers? WritingNumbers { get; set; }

        /// <summary>
        /// Formatting options for Zero Format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zero_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesNumbersZeroFormatJsonConverter))]
        public global::G.ConfiguredRulesNumbersZeroFormat? ZeroFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfiguredRulesNumbers" /> class.
        /// </summary>
        /// <param name="approximateNumbers">
        /// Formatting options for Approximate Numbers
        /// </param>
        /// <param name="currencyFormat">
        /// Formatting options for Currency Format
        /// </param>
        /// <param name="decimalNumbersLessThanOne">
        /// Formatting options for Decimal Numbers Less Than One
        /// </param>
        /// <param name="decimalSeparator">
        /// Formatting options for Decimal Separator
        /// </param>
        /// <param name="dimensionsSeparator">
        /// Formatting options for Dimensions Separator
        /// </param>
        /// <param name="equationFormulaReference">
        /// Formatting options for Equation Formula Reference
        /// </param>
        /// <param name="kanjiNumbers">
        /// Formatting options for Kanji Numbers
        /// </param>
        /// <param name="largeNumberFormat">
        /// Formatting options for Large Number Format
        /// </param>
        /// <param name="largeSumsOfMoney">
        /// Formatting options for Large Sums Of Money
        /// </param>
        /// <param name="largeSumsOfMoneyFormat">
        /// Formatting options for Large Sums Of Money Format
        /// </param>
        /// <param name="listOfMeasurementsWithUnits">
        /// Formatting options for List Of Measurements With Units
        /// </param>
        /// <param name="mathematicalExpressionSpacing">
        /// Formatting options for Mathematical Expression Spacing
        /// </param>
        /// <param name="numberFormat">
        /// Formatting options for Number Format
        /// </param>
        /// <param name="numberSeparator">
        /// Formatting options for Number Separator
        /// </param>
        /// <param name="numbersOf5DigitsOrMore">
        /// Formatting options for Numbers Of 5 Digits Or More
        /// </param>
        /// <param name="numbersUpTo4Digits">
        /// Formatting options for Numbers Up To 4 Digits
        /// </param>
        /// <param name="percentageFormat">
        /// Formatting options for Percentage Format
        /// </param>
        /// <param name="referenceToSymbol">
        /// Formatting options for Reference To Symbol
        /// </param>
        /// <param name="spellingOutUnits">
        /// Formatting options for Spelling Out Units
        /// </param>
        /// <param name="temperatureFormat">
        /// Formatting options for Temperature Format
        /// </param>
        /// <param name="thousandsSeparator">
        /// Formatting options for Thousands Separator
        /// </param>
        /// <param name="unitsOfMeasureSpacing">
        /// Formatting options for Units Of Measure Spacing
        /// </param>
        /// <param name="useOfHiraganaAndKanji">
        /// Formatting options for Use Of Hiragana And Kanji
        /// </param>
        /// <param name="writingNumbers">
        /// Formatting options for Writing Numbers
        /// </param>
        /// <param name="zeroFormat">
        /// Formatting options for Zero Format
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConfiguredRulesNumbers(
            global::G.ConfiguredRulesNumbersApproximateNumbers? approximateNumbers,
            global::G.ConfiguredRulesNumbersCurrencyFormat? currencyFormat,
            global::G.ConfiguredRulesNumbersDecimalNumbersLessThanOne? decimalNumbersLessThanOne,
            global::G.ConfiguredRulesNumbersDecimalSeparator? decimalSeparator,
            global::G.ConfiguredRulesNumbersDimensionsSeparator? dimensionsSeparator,
            global::G.ConfiguredRulesNumbersEquationFormulaReference? equationFormulaReference,
            global::G.ConfiguredRulesNumbersKanjiNumbers? kanjiNumbers,
            global::G.ConfiguredRulesNumbersLargeNumberFormat? largeNumberFormat,
            global::G.ConfiguredRulesNumbersLargeSumsOfMoney? largeSumsOfMoney,
            global::G.ConfiguredRulesNumbersLargeSumsOfMoneyFormat? largeSumsOfMoneyFormat,
            global::G.ConfiguredRulesNumbersListOfMeasurementsWithUnits? listOfMeasurementsWithUnits,
            global::G.ConfiguredRulesNumbersMathematicalExpressionSpacing? mathematicalExpressionSpacing,
            global::G.ConfiguredRulesNumbersNumberFormat? numberFormat,
            global::G.ConfiguredRulesNumbersNumberSeparator? numberSeparator,
            global::G.ConfiguredRulesNumbersNumbersOf5DigitsOrMore? numbersOf5DigitsOrMore,
            global::G.ConfiguredRulesNumbersNumbersUpTo4Digits? numbersUpTo4Digits,
            global::G.ConfiguredRulesNumbersPercentageFormat? percentageFormat,
            global::G.ConfiguredRulesNumbersReferenceToSymbol? referenceToSymbol,
            global::G.ConfiguredRulesNumbersSpellingOutUnits? spellingOutUnits,
            global::G.ConfiguredRulesNumbersTemperatureFormat? temperatureFormat,
            global::G.ConfiguredRulesNumbersThousandsSeparator? thousandsSeparator,
            global::G.ConfiguredRulesNumbersUnitsOfMeasureSpacing? unitsOfMeasureSpacing,
            global::G.ConfiguredRulesNumbersUseOfHiraganaAndKanji? useOfHiraganaAndKanji,
            global::G.ConfiguredRulesNumbersWritingNumbers? writingNumbers,
            global::G.ConfiguredRulesNumbersZeroFormat? zeroFormat)
        {
            this.ApproximateNumbers = approximateNumbers;
            this.CurrencyFormat = currencyFormat;
            this.DecimalNumbersLessThanOne = decimalNumbersLessThanOne;
            this.DecimalSeparator = decimalSeparator;
            this.DimensionsSeparator = dimensionsSeparator;
            this.EquationFormulaReference = equationFormulaReference;
            this.KanjiNumbers = kanjiNumbers;
            this.LargeNumberFormat = largeNumberFormat;
            this.LargeSumsOfMoney = largeSumsOfMoney;
            this.LargeSumsOfMoneyFormat = largeSumsOfMoneyFormat;
            this.ListOfMeasurementsWithUnits = listOfMeasurementsWithUnits;
            this.MathematicalExpressionSpacing = mathematicalExpressionSpacing;
            this.NumberFormat = numberFormat;
            this.NumberSeparator = numberSeparator;
            this.NumbersOf5DigitsOrMore = numbersOf5DigitsOrMore;
            this.NumbersUpTo4Digits = numbersUpTo4Digits;
            this.PercentageFormat = percentageFormat;
            this.ReferenceToSymbol = referenceToSymbol;
            this.SpellingOutUnits = spellingOutUnits;
            this.TemperatureFormat = temperatureFormat;
            this.ThousandsSeparator = thousandsSeparator;
            this.UnitsOfMeasureSpacing = unitsOfMeasureSpacing;
            this.UseOfHiraganaAndKanji = useOfHiraganaAndKanji;
            this.WritingNumbers = writingNumbers;
            this.ZeroFormat = zeroFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfiguredRulesNumbers" /> class.
        /// </summary>
        public ConfiguredRulesNumbers()
        {
        }
    }
}