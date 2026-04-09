//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The DeepL API provides programmatic access to DeepL’s language AI technology.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// DeepL API Pro
        /// </summary>
        public const string DefaultBaseUrl = "https://api.deepl.com";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::G.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif
        /// <summary>
        /// 
        /// </summary>
        #pragma warning disable CS0618 // Type or member is obsolete
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::G.JsonConverters.ConfiguredRulesDatesAndTimesCalendarEraJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesDatesAndTimesCalendarEraNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesDatesAndTimesCenturiesJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesDatesAndTimesCenturiesNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesDatesAndTimesDateFormatJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesDatesAndTimesDateFormatNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesDatesAndTimesDatesInNumericalFormJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesDatesAndTimesDatesInNumericalFormNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesDatesAndTimesDecadesJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesDatesAndTimesDecadesNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesDatesAndTimesHoursMinutesSecondsSeparatorJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesDatesAndTimesHoursMinutesSecondsSeparatorNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesDatesAndTimesHoursMinutesSeparatorJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesDatesAndTimesHoursMinutesSeparatorNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesDatesAndTimesMidnightInNumeralsJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesDatesAndTimesMidnightInNumeralsNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesDatesAndTimesSingleDigitDaysAndMonthsJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesDatesAndTimesSingleDigitDaysAndMonthsNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesDatesAndTimesSingleDigitHoursJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesDatesAndTimesSingleDigitHoursNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesDatesAndTimesTimeFormatJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesDatesAndTimesTimeFormatNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesDatesAndTimesWritingDatesJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesDatesAndTimesWritingDatesNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesDatesAndTimesYearsJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesDatesAndTimesYearsNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesFormattingEmailAddressFormatJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesFormattingEmailAddressFormatNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesFormattingPhoneNumberCountryCodeFormatJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesFormattingPhoneNumberCountryCodeFormatNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesFormattingPhoneNumberFormatJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesFormattingPhoneNumberFormatNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesFormattingSpaceBetweenArabicNumeralsAndUnitJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesFormattingSpaceBetweenArabicNumeralsAndUnitNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesFormattingSpaceBetweenChineseAndEnglishJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesFormattingSpaceBetweenChineseAndEnglishNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesFormattingSpaceBetweenChineseCharactersAndArabicNumeralsJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesFormattingSpaceBetweenChineseCharactersAndArabicNumeralsNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersApproximateNumbersJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersApproximateNumbersNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersCurrencyFormatJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersCurrencyFormatNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersDecimalNumbersLessThanOneJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersDecimalNumbersLessThanOneNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersDecimalSeparatorJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersDecimalSeparatorNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersDimensionsSeparatorJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersDimensionsSeparatorNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersEquationFormulaReferenceJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersEquationFormulaReferenceNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersKanjiNumbersJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersKanjiNumbersNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersLargeNumberFormatJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersLargeNumberFormatNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersLargeSumsOfMoneyJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersLargeSumsOfMoneyNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersLargeSumsOfMoneyFormatJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersLargeSumsOfMoneyFormatNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersListOfMeasurementsWithUnitsJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersListOfMeasurementsWithUnitsNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersMathematicalExpressionSpacingJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersMathematicalExpressionSpacingNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersNumberFormatJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersNumberFormatNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersNumberSeparatorJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersNumberSeparatorNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersNumbersOf5DigitsOrMoreJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersNumbersOf5DigitsOrMoreNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersNumbersUpTo4DigitsJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersNumbersUpTo4DigitsNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersPercentageFormatJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersPercentageFormatNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersReferenceToSymbolJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersReferenceToSymbolNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersSpellingOutUnitsJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersSpellingOutUnitsNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersTemperatureFormatJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersTemperatureFormatNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersThousandsSeparatorJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersThousandsSeparatorNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersUnitsOfMeasureSpacingJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersUnitsOfMeasureSpacingNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersUseOfHiraganaAndKanjiJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersUseOfHiraganaAndKanjiNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersWritingNumbersJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersWritingNumbersNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersZeroFormatJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesNumbersZeroFormatNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationAbbreviationsJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationAbbreviationsNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationAcronymsJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationAcronymsNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationAmpersandAbbreviationSpacingJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationAmpersandAbbreviationSpacingNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationAmpersandUsageJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationAmpersandUsageNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationApostropheJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationApostropheNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationBracketJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationBracketNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationChineseMixedWithEnglishJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationChineseMixedWithEnglishNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationColonJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationColonNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationColonBetweenHoursAndMinutesOrChaptersAndVersesJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationColonBetweenHoursAndMinutesOrChaptersAndVersesNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationColonInHeadingJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationColonInHeadingNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationColonToReplaceVersusOrToJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationColonToReplaceVersusOrToNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationCommaAfterConjunctiveAdverbsJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationCommaAfterConjunctiveAdverbsNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationCommaAfterIEAndEGJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationCommaAfterIEAndEGNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationCommaAfterShortIntroductoryPhraseJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationCommaAfterShortIntroductoryPhraseNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationCommaAndSemicolonJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationCommaAndSemicolonNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationCornerBracketAndPeriodsJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationCornerBracketAndPeriodsNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationCornerBracketsAndPeriodsJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationCornerBracketsAndPeriodsNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationDashJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationDashNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationEllipsisJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationEllipsisNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationEmDashJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationEmDashNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationEmphasisJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationEmphasisNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationExclamationMarksJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationExclamationMarksNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationExplanatoryNoteIndicatorJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationExplanatoryNoteIndicatorNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationFullSentenceInRoundBracketsJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationFullSentenceInRoundBracketsNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationHighlightingSpecificExpressionsJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationHighlightingSpecificExpressionsNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationJapaneseReferenceMaterialsJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationJapaneseReferenceMaterialsNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationParenthesesForSupplementaryInformationJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationParenthesesForSupplementaryInformationNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationPassageOfTimeAndMovementBetweenLocationsJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationPassageOfTimeAndMovementBetweenLocationsNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationPeriodsAndCommasJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationPeriodsAndCommasNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationPeriodsInAcademicDegreesJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationPeriodsInAcademicDegreesNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationPeriodsInDirectQuotesJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationPeriodsInDirectQuotesNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationPeriodsInUppercaseInitialismsAndAcronymsJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationPeriodsInUppercaseInitialismsAndAcronymsNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationPlusSignUsageJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationPlusSignUsageNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationPossessivesOfProperNamesEndingInSStyleJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationPossessivesOfProperNamesEndingInSStyleNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationQuotationMarkJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationQuotationMarkNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationQuotationMarkAndApostropheJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationQuotationMarkAndApostropheNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationQuotationStyleJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationQuotationStyleNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationRangeIndicatorJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationRangeIndicatorNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationRelatedPhrasesIndicatorJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationRelatedPhrasesIndicatorNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationRoundBracketsJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationRoundBracketsNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationSalutationJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationSalutationNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationSentenceBreakIndicatorJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationSentenceBreakIndicatorNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationSerialCommaJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationSerialCommaNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationSettingOffNonQuotedPhrasesJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationSettingOffNonQuotedPhrasesNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationSlashJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationSlashNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationSlashUsageJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationSlashUsageNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationSpacingAndPunctuationJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationSpacingAndPunctuationNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationTextInRoundBracketsReferringToPreviousSentenceJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationTextInRoundBracketsReferringToPreviousSentenceNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationTextInRoundBracketsSupplementingPrecedingTextJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationTextInRoundBracketsSupplementingPrecedingTextNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationTitlesOfBooksAndNewspapersJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationTitlesOfBooksAndNewspapersNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationTitlesOfCreativeWorksTradeNamesLawsAndRegulationsJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationTitlesOfCreativeWorksTradeNamesLawsAndRegulationsNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationUppercaseAcronymsJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesPunctuationUppercaseAcronymsNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarAbbreviatingFrenchWordNumeroJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarAbbreviatingFrenchWordNumeroNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarAbbreviationUsageJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarAbbreviationUsageNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarAccentsAndCedillasJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarAccentsAndCedillasNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarAccentsInVerbsConjugatedLikeFrenchWordCéderJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarAccentsInVerbsConjugatedLikeFrenchWordCéderNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarAccentsWithSubjectVerbInversionJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarAccentsWithSubjectVerbInversionNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarActivePassiveVoiceJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarActivePassiveVoiceNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarAllCapsJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarAllCapsNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarCompleteSentencesJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarCompleteSentencesNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarCompoundNounsJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarCompoundNounsNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarConjunctionsJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarConjunctionsNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarContractionsJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarContractionsNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarEstablishedLoanwordsJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarEstablishedLoanwordsNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarEszettJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarEszettNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarForeignWordTranslationJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarForeignWordTranslationNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarFrenchVerbsEndingInElerAndEterJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarFrenchVerbsEndingInElerAndEterNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarIAndUWithCircumflexAccentsJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarIAndUWithCircumflexAccentsNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarInformalAddressPronounsJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarInformalAddressPronounsNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarLatinAbbreviationsJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarLatinAbbreviationsNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarPassiveVoiceJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarPassiveVoiceNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarPastParticipleOfFrenchWordLaisserFollowedByInfinitiveJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarPastParticipleOfFrenchWordLaisserFollowedByInfinitiveNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarPersonalTitlesJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarPersonalTitlesNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarPluralizingForeignWordsJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarPluralizingForeignWordsNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarQuotationModificationJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarQuotationModificationNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarSpanishWordSoloJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarSpanishWordSoloNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarSpecialCharactersJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarSpecialCharactersNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarSpelledOutNumbersJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarSpelledOutNumbersNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarUmlautsJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarUmlautsNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarUnestablishedLoanwordsJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesSpellingAndGrammarUnestablishedLoanwordsNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneAbbreviationsJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneAbbreviationsNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneAddressingNonBinaryPeopleJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneAddressingNonBinaryPeopleNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneAddressingTheReaderJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneAddressingTheReaderNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneAnglicismsJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneAnglicismsNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneBinaryRepresentationOfGenderJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneBinaryRepresentationOfGenderNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneComplexSentencesJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneComplexSentencesNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneCountryNamesJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneCountryNamesNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneDeclarativeEndingsJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneDeclarativeEndingsNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneDefaultFirstPersonPronounJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneDefaultFirstPersonPronounNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneDefaultSecondPersonPronounJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneDefaultSecondPersonPronounNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneDirectionalLanguageJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneDirectionalLanguageNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneDoubleNegativesJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneDoubleNegativesNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneFormalityJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneFormalityNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneGenderNeutralLanguageReadabilityJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneGenderNeutralLanguageReadabilityNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneGenderUnspecifiedJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneGenderUnspecifiedNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneGenderUnspecifiedOrMixedJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneGenderUnspecifiedOrMixedNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneIdiomsColloquialismsAndCultureSpecificReferencesJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneIdiomsColloquialismsAndCultureSpecificReferencesNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneInflectedWordsMasculineNounAgreementJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneInflectedWordsMasculineNounAgreementNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneInstructionsStyleJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneInstructionsStyleNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneMixingStylesJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneMixingStylesNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneModalVerbsJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneModalVerbsNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndTonePersonalVsImpersonalStyleJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndTonePersonalVsImpersonalStyleNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndTonePositiveVsNegativeLanguageJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndTonePositiveVsNegativeLanguageNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneProximityAgreementJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneProximityAgreementNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneReaderActionRequiredJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneReaderActionRequiredNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneRedundantIntroductoryPhrasesJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneRedundantIntroductoryPhrasesNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneRedundantPhrasesJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneRedundantPhrasesNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneReferringToNonBinaryPeopleJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneReferringToNonBinaryPeopleNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneShortVsLongWordsJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneShortVsLongWordsNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneSimpleWordsAndSentencesJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneSimpleWordsAndSentencesNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneTextPositionReferencesJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneTextPositionReferencesNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneToneJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneToneNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneVerbalVsNominalStyleJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesStyleAndToneVerbalVsNominalStyleNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesVocabularyAbbreviationsJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesVocabularyAbbreviationsNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesVocabularyLoanwordsJsonConverter(),
                    new global::G.JsonConverters.ConfiguredRulesVocabularyLoanwordsNullableJsonConverter(),
                    new global::G.JsonConverters.CreateGlossaryParametersEntriesFormatJsonConverter(),
                    new global::G.JsonConverters.CreateGlossaryParametersEntriesFormatNullableJsonConverter(),
                    new global::G.JsonConverters.FormalityJsonConverter(),
                    new global::G.JsonConverters.FormalityNullableJsonConverter(),
                    new global::G.JsonConverters.GlossaryEntriesFormatJsonConverter(),
                    new global::G.JsonConverters.GlossaryEntriesFormatNullableJsonConverter(),
                    new global::G.JsonConverters.GlossarySourceLanguageJsonConverter(),
                    new global::G.JsonConverters.GlossarySourceLanguageNullableJsonConverter(),
                    new global::G.JsonConverters.GlossaryTargetLanguageJsonConverter(),
                    new global::G.JsonConverters.GlossaryTargetLanguageNullableJsonConverter(),
                    new global::G.JsonConverters.ModelTypeJsonConverter(),
                    new global::G.JsonConverters.ModelTypeNullableJsonConverter(),
                    new global::G.JsonConverters.OutlineDetectionOptionStrJsonConverter(),
                    new global::G.JsonConverters.OutlineDetectionOptionStrNullableJsonConverter(),
                    new global::G.JsonConverters.PreserveFormattingOptionStrJsonConverter(),
                    new global::G.JsonConverters.PreserveFormattingOptionStrNullableJsonConverter(),
                    new global::G.JsonConverters.SplitSentencesOptionJsonConverter(),
                    new global::G.JsonConverters.SplitSentencesOptionNullableJsonConverter(),
                    new global::G.JsonConverters.SourceLanguageJsonConverter(),
                    new global::G.JsonConverters.SourceLanguageNullableJsonConverter(),
                    new global::G.JsonConverters.StyleRuleLanguageJsonConverter(),
                    new global::G.JsonConverters.StyleRuleLanguageNullableJsonConverter(),
                    new global::G.JsonConverters.TagHandlingOptionJsonConverter(),
                    new global::G.JsonConverters.TagHandlingOptionNullableJsonConverter(),
                    new global::G.JsonConverters.TagHandlingVersionOptionJsonConverter(),
                    new global::G.JsonConverters.TagHandlingVersionOptionNullableJsonConverter(),
                    new global::G.JsonConverters.UsageResponseProductBillingUnitJsonConverter(),
                    new global::G.JsonConverters.UsageResponseProductBillingUnitNullableJsonConverter(),
                    new global::G.JsonConverters.TargetLanguageJsonConverter(),
                    new global::G.JsonConverters.TargetLanguageNullableJsonConverter(),
                    new global::G.JsonConverters.TargetLanguageWriteJsonConverter(),
                    new global::G.JsonConverters.TargetLanguageWriteNullableJsonConverter(),
                    new global::G.JsonConverters.VoiceFormalityJsonConverter(),
                    new global::G.JsonConverters.VoiceFormalityNullableJsonConverter(),
                    new global::G.JsonConverters.VoiceMediaContentTypeJsonConverter(),
                    new global::G.JsonConverters.VoiceMediaContentTypeNullableJsonConverter(),
                    new global::G.JsonConverters.VoiceSourceLanguageJsonConverter(),
                    new global::G.JsonConverters.VoiceSourceLanguageNullableJsonConverter(),
                    new global::G.JsonConverters.VoiceSourceLanguageModeJsonConverter(),
                    new global::G.JsonConverters.VoiceSourceLanguageModeNullableJsonConverter(),
                    new global::G.JsonConverters.WritingStyleJsonConverter(),
                    new global::G.JsonConverters.WritingStyleNullableJsonConverter(),
                    new global::G.JsonConverters.WritingToneJsonConverter(),
                    new global::G.JsonConverters.WritingToneNullableJsonConverter(),
                    new global::G.JsonConverters.AdminUsageReportDataGroupByJsonConverter(),
                    new global::G.JsonConverters.AdminUsageReportDataGroupByNullableJsonConverter(),
                    new global::G.JsonConverters.GetGlossaryEntriesAcceptJsonConverter(),
                    new global::G.JsonConverters.GetGlossaryEntriesAcceptNullableJsonConverter(),
                    new global::G.JsonConverters.GetLanguagesTypeJsonConverter(),
                    new global::G.JsonConverters.GetLanguagesTypeNullableJsonConverter(),
                    new global::G.JsonConverters.AdminGetAnalyticsGroupByJsonConverter(),
                    new global::G.JsonConverters.AdminGetAnalyticsGroupByNullableJsonConverter(),
                    new global::G.JsonConverters.GetDocumentStatusResponseStatusJsonConverter(),
                    new global::G.JsonConverters.GetDocumentStatusResponseStatusNullableJsonConverter(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// 
        /// </summary>
        public AdminApiClient AdminApi => new AdminApiClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Please note that this is the spec for the (old) v2 glossary endpoint.<br/>
        /// We recommend users switch to the newer v3 glossary endpoints, which support editability and multilinguality.<br/>
        /// The *glossary* functions allow you to create, inspect, and delete glossaries.<br/>
        /// Glossaries created with the glossary function can be used in translate requests by specifying the<br/>
        /// `glossary_id` parameter.<br/>
        /// If you encounter issues, please let us know at support@DeepL.com.<br/>
        /// Currently you can create glossaries with any of the languages DeepL supports.<br/>
        /// The maximum size limit for a glossary is 10 MiB = 10485760 bytes and each source/target text,<br/>
        /// as well as the name of the glossary, is limited to 1024 UTF-8 bytes.<br/>
        /// A total of 1000 glossaries are allowed per account.<br/>
        /// When creating a glossary with target language `EN`, `PT`, or `ZH`, it's not necessary to specify a variant<br/>
        /// (e.g. `EN-US`, `EN-GB`, `PT-PT`, `PT-BR`, or `ZH-HANS`).<br/>
        /// Glossaries with target language `EN` can be used in translations with either English variant.<br/>
        /// Similarly `PT`, and `ZH` glossaries can be used in translations with their corresponding variants.<br/>
        /// Note that on the v2 API, glossaries are immutable: once created, the glossary entries for a given glossary ID cannot be modified.<br/>
        /// As a workaround for effectively editable glossaries, we suggest to identify glossaries by name instead of ID in your application<br/>
        /// and then use the following procedure for modifications:<br/>
        /// - [download](https://www.deepl.com/docs-api/glossaries/get-glossary-entries) and store the current glossary's entries,<br/>
        /// - locally modify the glossary entries,<br/>
        /// - [delete](https://www.deepl.com/docs-api/glossaries/delete-glossary) the existing glossary,<br/>
        /// - [create a new glossary](https://www.deepl.com/docs-api/glossaries/create-glossary) with the same name.
        /// </summary>
        public ManageGlossariesClient ManageGlossaries => new ManageGlossariesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// The *glossary* functions allow you to create, inspect, edit and delete glossaries.<br/>
        /// Glossaries created with the glossary function can be used in translate requests by specifying the<br/>
        /// `glossary_id` parameter. A glossary contains (several) dictionaries.<br/>
        /// A dictionary is a mapping of source phrases to target phrases for a single language pair.<br/>
        /// If you encounter issues, please let us know at support@DeepL.com.<br/>
        /// Currently you can create glossaries with any of the languages DeepL supports.<br/>
        /// The maximum size limit for a glossary is 10 MiB = 10485760 bytes and each source/target text,<br/>
        /// as well as the name of the glossary, is limited to 1024 UTF-8 bytes.<br/>
        /// A total of 1000 glossaries are allowed per account.<br/>
        /// When creating a dictionary with target language `EN`, `PT`, or `ZH`, it's not necessary to specify a variant<br/>
        /// (e.g. `EN-US`, `EN-GB`, `PT-PT`, `PT-BR`, or `ZH-HANS`).<br/>
        /// Dictionaries with target language `EN` can be used in translations with either English variant.<br/>
        /// Similarly `PT`, and `ZH` dictionaries can be used in translations with their corresponding variants.<br/>
        /// (When you provide the ID of a glossary to a translation, the appropriate dictionary is automatically applied. Currently glossaries can not yet be used with source language detection.)<br/>
        /// Glossaries created via the DeepL API are now unified with glossaries created via the DeepL website and DeepL apps.<br/>
        /// Please only use the v3 glossary API in conjunction with multilingual or edited glossaries from the website.
        /// </summary>
        public ManageMultilingualGlossariesClient ManageMultilingualGlossaries => new ManageMultilingualGlossariesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Information about API usage and value ranges
        /// </summary>
        public MetaInformationClient MetaInformation => new MetaInformationClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// The `rephrase` endpoint  is used to make corrections and adjustments to texts based on style or tone.<br/>
        /// For more details, visit [this documentation page](https://developers.deepl.com/docs/api-reference/improve-text)
        /// </summary>
        public RephraseTextClient RephraseText => new RephraseTextClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// The *style rules* functions allow you to create, inspect, edit and delete style rules.<br/>
        /// Style rules can be used in translate requests by specifying the `style_id` parameter, allowing you to<br/>
        /// select a set of rules to apply when translating text. These rules make changes to your text according<br/>
        /// to the selected formatting and spelling conventions.<br/>
        /// If you encounter issues, please let us know at support@DeepL.com.
        /// </summary>
        public StyleRulesClient StyleRules => new StyleRulesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// The document translation API allows you to translate whole documents and supports the following file types and extensions:<br/>
        ///   * `docx` - Microsoft Word Document<br/>
        ///   * `pptx` - Microsoft PowerPoint Document<br/>
        ///   * `xlsx` - Microsoft Excel Document<br/>
        ///   * `pdf` - Portable Document Format<br/>
        ///   * `htm / html` - HTML Document<br/>
        ///   * `txt` - Plain Text Document<br/>
        ///   * `xlf / xliff` - XLIFF Document, version 2.1<br/>
        ///   * `srt` - SRT Document<br/>
        ///   * `jpeg / jpg / png` - Image<br/>
        /// Please note that with every submitted document of type .pptx, .docx, .xlsx, or .pdf,<br/>
        /// you are billed a minimum of 50,000 characters with the DeepL API plan,<br/>
        /// no matter how many characters are included in the document.<br/>
        /// Translating a document usually involves three types of HTTP requests:<br/>
        ///   - [upload](https://www.deepl.com/docs-api/documents/translate-document) the document to be translated,<br/>
        ///   - periodically [check the status](https://www.deepl.com/docs-api/documents/get-document-status) of the document translation,<br/>
        ///   - once the status call reports `done`, [download](https://www.deepl.com/docs-api/documents/download-document) the translated document.<br/>
        /// To learn more about context in DeepL API translations, we recommend [this article](https://www.deepl.com/docs-api/general/working-with-context).
        /// </summary>
        public TranslateDocumentsClient TranslateDocuments => new TranslateDocumentsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// The text-translation API currently consists of a single endpoint, `translate`, which is described below.<br/>
        /// To learn more about context in DeepL API translations, we recommend [this article](https://www.deepl.com/docs-api/general/working-with-context).
        /// </summary>
        public TranslateTextClient TranslateText => new TranslateTextClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// The Voice API provides real-time voice transcription and translation services.<br/>
        /// Use a two-step flow: first request a streaming URL via REST, then establish a WebSocket connection for streaming audio and receiving transcriptions.
        /// </summary>
        public VoiceAPIClient VoiceAPI => new VoiceAPIClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Creates a new instance of the Api.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::G.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::G.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}