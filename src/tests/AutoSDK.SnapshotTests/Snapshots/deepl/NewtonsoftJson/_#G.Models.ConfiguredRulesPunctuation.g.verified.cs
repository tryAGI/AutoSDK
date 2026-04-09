//HintName: G.Models.ConfiguredRulesPunctuation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConfiguredRulesPunctuation
    {
        /// <summary>
        /// Formatting options for Abbreviations
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("abbreviations")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationAbbreviationsJsonConverter))]
        public global::G.ConfiguredRulesPunctuationAbbreviations? Abbreviations { get; set; }

        /// <summary>
        /// Formatting options for Acronyms
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("acronyms")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationAcronymsJsonConverter))]
        public global::G.ConfiguredRulesPunctuationAcronyms? Acronyms { get; set; }

        /// <summary>
        /// Formatting options for Ampersand Abbreviation Spacing
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ampersand_abbreviation_spacing")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationAmpersandAbbreviationSpacingJsonConverter))]
        public global::G.ConfiguredRulesPunctuationAmpersandAbbreviationSpacing? AmpersandAbbreviationSpacing { get; set; }

        /// <summary>
        /// Formatting options for Ampersand Usage
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ampersand_usage")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationAmpersandUsageJsonConverter))]
        public global::G.ConfiguredRulesPunctuationAmpersandUsage? AmpersandUsage { get; set; }

        /// <summary>
        /// Formatting options for Apostrophe
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apostrophe")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationApostropheJsonConverter))]
        public global::G.ConfiguredRulesPunctuationApostrophe? Apostrophe { get; set; }

        /// <summary>
        /// Formatting options for Bracket
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bracket")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationBracketJsonConverter))]
        public global::G.ConfiguredRulesPunctuationBracket? Bracket { get; set; }

        /// <summary>
        /// Formatting options for Chinese Mixed With English
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chinese_mixed_with_english")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationChineseMixedWithEnglishJsonConverter))]
        public global::G.ConfiguredRulesPunctuationChineseMixedWithEnglish? ChineseMixedWithEnglish { get; set; }

        /// <summary>
        /// Formatting options for Colon
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("colon")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationColonJsonConverter))]
        public global::G.ConfiguredRulesPunctuationColon? Colon { get; set; }

        /// <summary>
        /// Formatting options for Colon Between Hours And Minutes Or Chapters And Verses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("colon_between_hours_and_minutes_or_chapters_and_verses")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationColonBetweenHoursAndMinutesOrChaptersAndVersesJsonConverter))]
        public global::G.ConfiguredRulesPunctuationColonBetweenHoursAndMinutesOrChaptersAndVerses? ColonBetweenHoursAndMinutesOrChaptersAndVerses { get; set; }

        /// <summary>
        /// Formatting options for Colon In Heading
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("colon_in_heading")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationColonInHeadingJsonConverter))]
        public global::G.ConfiguredRulesPunctuationColonInHeading? ColonInHeading { get; set; }

        /// <summary>
        /// Formatting options for Colon To Replace Versus Or To
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("colon_to_replace_versus_or_to")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationColonToReplaceVersusOrToJsonConverter))]
        public global::G.ConfiguredRulesPunctuationColonToReplaceVersusOrTo? ColonToReplaceVersusOrTo { get; set; }

        /// <summary>
        /// Formatting options for Comma After Conjunctive Adverbs
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comma_after_conjunctive_adverbs")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationCommaAfterConjunctiveAdverbsJsonConverter))]
        public global::G.ConfiguredRulesPunctuationCommaAfterConjunctiveAdverbs? CommaAfterConjunctiveAdverbs { get; set; }

        /// <summary>
        /// Formatting options for Comma After I E And E G
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comma_after_i_e_and_e_g")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationCommaAfterIEAndEGJsonConverter))]
        public global::G.ConfiguredRulesPunctuationCommaAfterIEAndEG? CommaAfterIEAndEG { get; set; }

        /// <summary>
        /// Formatting options for Comma After Short Introductory Phrase
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comma_after_short_introductory_phrase")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationCommaAfterShortIntroductoryPhraseJsonConverter))]
        public global::G.ConfiguredRulesPunctuationCommaAfterShortIntroductoryPhrase? CommaAfterShortIntroductoryPhrase { get; set; }

        /// <summary>
        /// Formatting options for Comma And Semicolon
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comma_and_semicolon")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationCommaAndSemicolonJsonConverter))]
        public global::G.ConfiguredRulesPunctuationCommaAndSemicolon? CommaAndSemicolon { get; set; }

        /// <summary>
        /// Formatting options for Corner Bracket And Periods
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("corner_bracket_and_periods")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationCornerBracketAndPeriodsJsonConverter))]
        public global::G.ConfiguredRulesPunctuationCornerBracketAndPeriods? CornerBracketAndPeriods { get; set; }

        /// <summary>
        /// Formatting options for Corner Brackets And Periods
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("corner_brackets_and_periods")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationCornerBracketsAndPeriodsJsonConverter))]
        public global::G.ConfiguredRulesPunctuationCornerBracketsAndPeriods? CornerBracketsAndPeriods { get; set; }

        /// <summary>
        /// Formatting options for Dash
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dash")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationDashJsonConverter))]
        public global::G.ConfiguredRulesPunctuationDash? Dash { get; set; }

        /// <summary>
        /// Formatting options for Ellipsis
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ellipsis")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationEllipsisJsonConverter))]
        public global::G.ConfiguredRulesPunctuationEllipsis? Ellipsis { get; set; }

        /// <summary>
        /// Formatting options for Em Dash
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("em_dash")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationEmDashJsonConverter))]
        public global::G.ConfiguredRulesPunctuationEmDash? EmDash { get; set; }

        /// <summary>
        /// Formatting options for Emphasis
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("emphasis")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationEmphasisJsonConverter))]
        public global::G.ConfiguredRulesPunctuationEmphasis? Emphasis { get; set; }

        /// <summary>
        /// Formatting options for Exclamation Marks
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclamation_marks")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationExclamationMarksJsonConverter))]
        public global::G.ConfiguredRulesPunctuationExclamationMarks? ExclamationMarks { get; set; }

        /// <summary>
        /// Formatting options for Explanatory Note Indicator
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("explanatory_note_indicator")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationExplanatoryNoteIndicatorJsonConverter))]
        public global::G.ConfiguredRulesPunctuationExplanatoryNoteIndicator? ExplanatoryNoteIndicator { get; set; }

        /// <summary>
        /// Formatting options for Full Sentence In Round Brackets
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("full_sentence_in_round_brackets")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationFullSentenceInRoundBracketsJsonConverter))]
        public global::G.ConfiguredRulesPunctuationFullSentenceInRoundBrackets? FullSentenceInRoundBrackets { get; set; }

        /// <summary>
        /// Formatting options for Highlighting Specific Expressions
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("highlighting_specific_expressions")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationHighlightingSpecificExpressionsJsonConverter))]
        public global::G.ConfiguredRulesPunctuationHighlightingSpecificExpressions? HighlightingSpecificExpressions { get; set; }

        /// <summary>
        /// Formatting options for Japanese Reference Materials
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("japanese_reference_materials")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationJapaneseReferenceMaterialsJsonConverter))]
        public global::G.ConfiguredRulesPunctuationJapaneseReferenceMaterials? JapaneseReferenceMaterials { get; set; }

        /// <summary>
        /// Formatting options for Parentheses For Supplementary Information
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parentheses_for_supplementary_information")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationParenthesesForSupplementaryInformationJsonConverter))]
        public global::G.ConfiguredRulesPunctuationParenthesesForSupplementaryInformation? ParenthesesForSupplementaryInformation { get; set; }

        /// <summary>
        /// Formatting options for Passage Of Time And Movement Between Locations
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("passage_of_time_and_movement_between_locations")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationPassageOfTimeAndMovementBetweenLocationsJsonConverter))]
        public global::G.ConfiguredRulesPunctuationPassageOfTimeAndMovementBetweenLocations? PassageOfTimeAndMovementBetweenLocations { get; set; }

        /// <summary>
        /// Formatting options for Periods And Commas
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("periods_and_commas")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationPeriodsAndCommasJsonConverter))]
        public global::G.ConfiguredRulesPunctuationPeriodsAndCommas? PeriodsAndCommas { get; set; }

        /// <summary>
        /// Formatting options for Periods In Academic Degrees
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("periods_in_academic_degrees")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationPeriodsInAcademicDegreesJsonConverter))]
        public global::G.ConfiguredRulesPunctuationPeriodsInAcademicDegrees? PeriodsInAcademicDegrees { get; set; }

        /// <summary>
        /// Formatting options for Periods In Direct Quotes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("periods_in_direct_quotes")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationPeriodsInDirectQuotesJsonConverter))]
        public global::G.ConfiguredRulesPunctuationPeriodsInDirectQuotes? PeriodsInDirectQuotes { get; set; }

        /// <summary>
        /// Formatting options for Periods In Uppercase Initialisms And Acronyms
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("periods_in_uppercase_initialisms_and_acronyms")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationPeriodsInUppercaseInitialismsAndAcronymsJsonConverter))]
        public global::G.ConfiguredRulesPunctuationPeriodsInUppercaseInitialismsAndAcronyms? PeriodsInUppercaseInitialismsAndAcronyms { get; set; }

        /// <summary>
        /// Formatting options for Plus Sign Usage
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("plus_sign_usage")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationPlusSignUsageJsonConverter))]
        public global::G.ConfiguredRulesPunctuationPlusSignUsage? PlusSignUsage { get; set; }

        /// <summary>
        /// Formatting options for Possessives Of Proper Names Ending In S Style
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("possessives_of_proper_names_ending_in_s_style")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationPossessivesOfProperNamesEndingInSStyleJsonConverter))]
        public global::G.ConfiguredRulesPunctuationPossessivesOfProperNamesEndingInSStyle? PossessivesOfProperNamesEndingInSStyle { get; set; }

        /// <summary>
        /// Formatting options for Quotation Mark
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("quotation_mark")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationQuotationMarkJsonConverter))]
        public global::G.ConfiguredRulesPunctuationQuotationMark? QuotationMark { get; set; }

        /// <summary>
        /// Formatting options for Quotation Mark And Apostrophe
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("quotation_mark_and_apostrophe")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationQuotationMarkAndApostropheJsonConverter))]
        public global::G.ConfiguredRulesPunctuationQuotationMarkAndApostrophe? QuotationMarkAndApostrophe { get; set; }

        /// <summary>
        /// Formatting options for Quotation Style
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("quotation_style")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationQuotationStyleJsonConverter))]
        public global::G.ConfiguredRulesPunctuationQuotationStyle? QuotationStyle { get; set; }

        /// <summary>
        /// Formatting options for Range Indicator
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("range_indicator")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationRangeIndicatorJsonConverter))]
        public global::G.ConfiguredRulesPunctuationRangeIndicator? RangeIndicator { get; set; }

        /// <summary>
        /// Formatting options for Related Phrases Indicator
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("related_phrases_indicator")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationRelatedPhrasesIndicatorJsonConverter))]
        public global::G.ConfiguredRulesPunctuationRelatedPhrasesIndicator? RelatedPhrasesIndicator { get; set; }

        /// <summary>
        /// Formatting options for Round Brackets
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("round_brackets")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationRoundBracketsJsonConverter))]
        public global::G.ConfiguredRulesPunctuationRoundBrackets? RoundBrackets { get; set; }

        /// <summary>
        /// Formatting options for Salutation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("salutation")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationSalutationJsonConverter))]
        public global::G.ConfiguredRulesPunctuationSalutation? Salutation { get; set; }

        /// <summary>
        /// Formatting options for Sentence Break Indicator
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sentence_break_indicator")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationSentenceBreakIndicatorJsonConverter))]
        public global::G.ConfiguredRulesPunctuationSentenceBreakIndicator? SentenceBreakIndicator { get; set; }

        /// <summary>
        /// Formatting options for Serial Comma
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("serial_comma")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationSerialCommaJsonConverter))]
        public global::G.ConfiguredRulesPunctuationSerialComma? SerialComma { get; set; }

        /// <summary>
        /// Formatting options for Setting Off Non Quoted Phrases
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("setting_off_non_quoted_phrases")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationSettingOffNonQuotedPhrasesJsonConverter))]
        public global::G.ConfiguredRulesPunctuationSettingOffNonQuotedPhrases? SettingOffNonQuotedPhrases { get; set; }

        /// <summary>
        /// Formatting options for Slash
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slash")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationSlashJsonConverter))]
        public global::G.ConfiguredRulesPunctuationSlash? Slash { get; set; }

        /// <summary>
        /// Formatting options for Slash Usage
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slash_usage")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationSlashUsageJsonConverter))]
        public global::G.ConfiguredRulesPunctuationSlashUsage? SlashUsage { get; set; }

        /// <summary>
        /// Formatting options for Spacing And Punctuation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("spacing_and_punctuation")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationSpacingAndPunctuationJsonConverter))]
        public global::G.ConfiguredRulesPunctuationSpacingAndPunctuation? SpacingAndPunctuation { get; set; }

        /// <summary>
        /// Formatting options for Text In Round Brackets Referring To Previous Sentence
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text_in_round_brackets_referring_to_previous_sentence")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationTextInRoundBracketsReferringToPreviousSentenceJsonConverter))]
        public global::G.ConfiguredRulesPunctuationTextInRoundBracketsReferringToPreviousSentence? TextInRoundBracketsReferringToPreviousSentence { get; set; }

        /// <summary>
        /// Formatting options for Text In Round Brackets Supplementing Preceding Text
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text_in_round_brackets_supplementing_preceding_text")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationTextInRoundBracketsSupplementingPrecedingTextJsonConverter))]
        public global::G.ConfiguredRulesPunctuationTextInRoundBracketsSupplementingPrecedingText? TextInRoundBracketsSupplementingPrecedingText { get; set; }

        /// <summary>
        /// Formatting options for Titles Of Books And Newspapers
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("titles_of_books_and_newspapers")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationTitlesOfBooksAndNewspapersJsonConverter))]
        public global::G.ConfiguredRulesPunctuationTitlesOfBooksAndNewspapers? TitlesOfBooksAndNewspapers { get; set; }

        /// <summary>
        /// Formatting options for Titles Of Creative Works Trade Names Laws And Regulations
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("titles_of_creative_works_trade_names_laws_and_regulations")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationTitlesOfCreativeWorksTradeNamesLawsAndRegulationsJsonConverter))]
        public global::G.ConfiguredRulesPunctuationTitlesOfCreativeWorksTradeNamesLawsAndRegulations? TitlesOfCreativeWorksTradeNamesLawsAndRegulations { get; set; }

        /// <summary>
        /// Formatting options for Uppercase Acronyms
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uppercase_acronyms")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesPunctuationUppercaseAcronymsJsonConverter))]
        public global::G.ConfiguredRulesPunctuationUppercaseAcronyms? UppercaseAcronyms { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfiguredRulesPunctuation" /> class.
        /// </summary>
        /// <param name="abbreviations">
        /// Formatting options for Abbreviations
        /// </param>
        /// <param name="acronyms">
        /// Formatting options for Acronyms
        /// </param>
        /// <param name="ampersandAbbreviationSpacing">
        /// Formatting options for Ampersand Abbreviation Spacing
        /// </param>
        /// <param name="ampersandUsage">
        /// Formatting options for Ampersand Usage
        /// </param>
        /// <param name="apostrophe">
        /// Formatting options for Apostrophe
        /// </param>
        /// <param name="bracket">
        /// Formatting options for Bracket
        /// </param>
        /// <param name="chineseMixedWithEnglish">
        /// Formatting options for Chinese Mixed With English
        /// </param>
        /// <param name="colon">
        /// Formatting options for Colon
        /// </param>
        /// <param name="colonBetweenHoursAndMinutesOrChaptersAndVerses">
        /// Formatting options for Colon Between Hours And Minutes Or Chapters And Verses
        /// </param>
        /// <param name="colonInHeading">
        /// Formatting options for Colon In Heading
        /// </param>
        /// <param name="colonToReplaceVersusOrTo">
        /// Formatting options for Colon To Replace Versus Or To
        /// </param>
        /// <param name="commaAfterConjunctiveAdverbs">
        /// Formatting options for Comma After Conjunctive Adverbs
        /// </param>
        /// <param name="commaAfterIEAndEG">
        /// Formatting options for Comma After I E And E G
        /// </param>
        /// <param name="commaAfterShortIntroductoryPhrase">
        /// Formatting options for Comma After Short Introductory Phrase
        /// </param>
        /// <param name="commaAndSemicolon">
        /// Formatting options for Comma And Semicolon
        /// </param>
        /// <param name="cornerBracketAndPeriods">
        /// Formatting options for Corner Bracket And Periods
        /// </param>
        /// <param name="cornerBracketsAndPeriods">
        /// Formatting options for Corner Brackets And Periods
        /// </param>
        /// <param name="dash">
        /// Formatting options for Dash
        /// </param>
        /// <param name="ellipsis">
        /// Formatting options for Ellipsis
        /// </param>
        /// <param name="emDash">
        /// Formatting options for Em Dash
        /// </param>
        /// <param name="emphasis">
        /// Formatting options for Emphasis
        /// </param>
        /// <param name="exclamationMarks">
        /// Formatting options for Exclamation Marks
        /// </param>
        /// <param name="explanatoryNoteIndicator">
        /// Formatting options for Explanatory Note Indicator
        /// </param>
        /// <param name="fullSentenceInRoundBrackets">
        /// Formatting options for Full Sentence In Round Brackets
        /// </param>
        /// <param name="highlightingSpecificExpressions">
        /// Formatting options for Highlighting Specific Expressions
        /// </param>
        /// <param name="japaneseReferenceMaterials">
        /// Formatting options for Japanese Reference Materials
        /// </param>
        /// <param name="parenthesesForSupplementaryInformation">
        /// Formatting options for Parentheses For Supplementary Information
        /// </param>
        /// <param name="passageOfTimeAndMovementBetweenLocations">
        /// Formatting options for Passage Of Time And Movement Between Locations
        /// </param>
        /// <param name="periodsAndCommas">
        /// Formatting options for Periods And Commas
        /// </param>
        /// <param name="periodsInAcademicDegrees">
        /// Formatting options for Periods In Academic Degrees
        /// </param>
        /// <param name="periodsInDirectQuotes">
        /// Formatting options for Periods In Direct Quotes
        /// </param>
        /// <param name="periodsInUppercaseInitialismsAndAcronyms">
        /// Formatting options for Periods In Uppercase Initialisms And Acronyms
        /// </param>
        /// <param name="plusSignUsage">
        /// Formatting options for Plus Sign Usage
        /// </param>
        /// <param name="possessivesOfProperNamesEndingInSStyle">
        /// Formatting options for Possessives Of Proper Names Ending In S Style
        /// </param>
        /// <param name="quotationMark">
        /// Formatting options for Quotation Mark
        /// </param>
        /// <param name="quotationMarkAndApostrophe">
        /// Formatting options for Quotation Mark And Apostrophe
        /// </param>
        /// <param name="quotationStyle">
        /// Formatting options for Quotation Style
        /// </param>
        /// <param name="rangeIndicator">
        /// Formatting options for Range Indicator
        /// </param>
        /// <param name="relatedPhrasesIndicator">
        /// Formatting options for Related Phrases Indicator
        /// </param>
        /// <param name="roundBrackets">
        /// Formatting options for Round Brackets
        /// </param>
        /// <param name="salutation">
        /// Formatting options for Salutation
        /// </param>
        /// <param name="sentenceBreakIndicator">
        /// Formatting options for Sentence Break Indicator
        /// </param>
        /// <param name="serialComma">
        /// Formatting options for Serial Comma
        /// </param>
        /// <param name="settingOffNonQuotedPhrases">
        /// Formatting options for Setting Off Non Quoted Phrases
        /// </param>
        /// <param name="slash">
        /// Formatting options for Slash
        /// </param>
        /// <param name="slashUsage">
        /// Formatting options for Slash Usage
        /// </param>
        /// <param name="spacingAndPunctuation">
        /// Formatting options for Spacing And Punctuation
        /// </param>
        /// <param name="textInRoundBracketsReferringToPreviousSentence">
        /// Formatting options for Text In Round Brackets Referring To Previous Sentence
        /// </param>
        /// <param name="textInRoundBracketsSupplementingPrecedingText">
        /// Formatting options for Text In Round Brackets Supplementing Preceding Text
        /// </param>
        /// <param name="titlesOfBooksAndNewspapers">
        /// Formatting options for Titles Of Books And Newspapers
        /// </param>
        /// <param name="titlesOfCreativeWorksTradeNamesLawsAndRegulations">
        /// Formatting options for Titles Of Creative Works Trade Names Laws And Regulations
        /// </param>
        /// <param name="uppercaseAcronyms">
        /// Formatting options for Uppercase Acronyms
        /// </param>
        public ConfiguredRulesPunctuation(
            global::G.ConfiguredRulesPunctuationAbbreviations? abbreviations,
            global::G.ConfiguredRulesPunctuationAcronyms? acronyms,
            global::G.ConfiguredRulesPunctuationAmpersandAbbreviationSpacing? ampersandAbbreviationSpacing,
            global::G.ConfiguredRulesPunctuationAmpersandUsage? ampersandUsage,
            global::G.ConfiguredRulesPunctuationApostrophe? apostrophe,
            global::G.ConfiguredRulesPunctuationBracket? bracket,
            global::G.ConfiguredRulesPunctuationChineseMixedWithEnglish? chineseMixedWithEnglish,
            global::G.ConfiguredRulesPunctuationColon? colon,
            global::G.ConfiguredRulesPunctuationColonBetweenHoursAndMinutesOrChaptersAndVerses? colonBetweenHoursAndMinutesOrChaptersAndVerses,
            global::G.ConfiguredRulesPunctuationColonInHeading? colonInHeading,
            global::G.ConfiguredRulesPunctuationColonToReplaceVersusOrTo? colonToReplaceVersusOrTo,
            global::G.ConfiguredRulesPunctuationCommaAfterConjunctiveAdverbs? commaAfterConjunctiveAdverbs,
            global::G.ConfiguredRulesPunctuationCommaAfterIEAndEG? commaAfterIEAndEG,
            global::G.ConfiguredRulesPunctuationCommaAfterShortIntroductoryPhrase? commaAfterShortIntroductoryPhrase,
            global::G.ConfiguredRulesPunctuationCommaAndSemicolon? commaAndSemicolon,
            global::G.ConfiguredRulesPunctuationCornerBracketAndPeriods? cornerBracketAndPeriods,
            global::G.ConfiguredRulesPunctuationCornerBracketsAndPeriods? cornerBracketsAndPeriods,
            global::G.ConfiguredRulesPunctuationDash? dash,
            global::G.ConfiguredRulesPunctuationEllipsis? ellipsis,
            global::G.ConfiguredRulesPunctuationEmDash? emDash,
            global::G.ConfiguredRulesPunctuationEmphasis? emphasis,
            global::G.ConfiguredRulesPunctuationExclamationMarks? exclamationMarks,
            global::G.ConfiguredRulesPunctuationExplanatoryNoteIndicator? explanatoryNoteIndicator,
            global::G.ConfiguredRulesPunctuationFullSentenceInRoundBrackets? fullSentenceInRoundBrackets,
            global::G.ConfiguredRulesPunctuationHighlightingSpecificExpressions? highlightingSpecificExpressions,
            global::G.ConfiguredRulesPunctuationJapaneseReferenceMaterials? japaneseReferenceMaterials,
            global::G.ConfiguredRulesPunctuationParenthesesForSupplementaryInformation? parenthesesForSupplementaryInformation,
            global::G.ConfiguredRulesPunctuationPassageOfTimeAndMovementBetweenLocations? passageOfTimeAndMovementBetweenLocations,
            global::G.ConfiguredRulesPunctuationPeriodsAndCommas? periodsAndCommas,
            global::G.ConfiguredRulesPunctuationPeriodsInAcademicDegrees? periodsInAcademicDegrees,
            global::G.ConfiguredRulesPunctuationPeriodsInDirectQuotes? periodsInDirectQuotes,
            global::G.ConfiguredRulesPunctuationPeriodsInUppercaseInitialismsAndAcronyms? periodsInUppercaseInitialismsAndAcronyms,
            global::G.ConfiguredRulesPunctuationPlusSignUsage? plusSignUsage,
            global::G.ConfiguredRulesPunctuationPossessivesOfProperNamesEndingInSStyle? possessivesOfProperNamesEndingInSStyle,
            global::G.ConfiguredRulesPunctuationQuotationMark? quotationMark,
            global::G.ConfiguredRulesPunctuationQuotationMarkAndApostrophe? quotationMarkAndApostrophe,
            global::G.ConfiguredRulesPunctuationQuotationStyle? quotationStyle,
            global::G.ConfiguredRulesPunctuationRangeIndicator? rangeIndicator,
            global::G.ConfiguredRulesPunctuationRelatedPhrasesIndicator? relatedPhrasesIndicator,
            global::G.ConfiguredRulesPunctuationRoundBrackets? roundBrackets,
            global::G.ConfiguredRulesPunctuationSalutation? salutation,
            global::G.ConfiguredRulesPunctuationSentenceBreakIndicator? sentenceBreakIndicator,
            global::G.ConfiguredRulesPunctuationSerialComma? serialComma,
            global::G.ConfiguredRulesPunctuationSettingOffNonQuotedPhrases? settingOffNonQuotedPhrases,
            global::G.ConfiguredRulesPunctuationSlash? slash,
            global::G.ConfiguredRulesPunctuationSlashUsage? slashUsage,
            global::G.ConfiguredRulesPunctuationSpacingAndPunctuation? spacingAndPunctuation,
            global::G.ConfiguredRulesPunctuationTextInRoundBracketsReferringToPreviousSentence? textInRoundBracketsReferringToPreviousSentence,
            global::G.ConfiguredRulesPunctuationTextInRoundBracketsSupplementingPrecedingText? textInRoundBracketsSupplementingPrecedingText,
            global::G.ConfiguredRulesPunctuationTitlesOfBooksAndNewspapers? titlesOfBooksAndNewspapers,
            global::G.ConfiguredRulesPunctuationTitlesOfCreativeWorksTradeNamesLawsAndRegulations? titlesOfCreativeWorksTradeNamesLawsAndRegulations,
            global::G.ConfiguredRulesPunctuationUppercaseAcronyms? uppercaseAcronyms)
        {
            this.Abbreviations = abbreviations;
            this.Acronyms = acronyms;
            this.AmpersandAbbreviationSpacing = ampersandAbbreviationSpacing;
            this.AmpersandUsage = ampersandUsage;
            this.Apostrophe = apostrophe;
            this.Bracket = bracket;
            this.ChineseMixedWithEnglish = chineseMixedWithEnglish;
            this.Colon = colon;
            this.ColonBetweenHoursAndMinutesOrChaptersAndVerses = colonBetweenHoursAndMinutesOrChaptersAndVerses;
            this.ColonInHeading = colonInHeading;
            this.ColonToReplaceVersusOrTo = colonToReplaceVersusOrTo;
            this.CommaAfterConjunctiveAdverbs = commaAfterConjunctiveAdverbs;
            this.CommaAfterIEAndEG = commaAfterIEAndEG;
            this.CommaAfterShortIntroductoryPhrase = commaAfterShortIntroductoryPhrase;
            this.CommaAndSemicolon = commaAndSemicolon;
            this.CornerBracketAndPeriods = cornerBracketAndPeriods;
            this.CornerBracketsAndPeriods = cornerBracketsAndPeriods;
            this.Dash = dash;
            this.Ellipsis = ellipsis;
            this.EmDash = emDash;
            this.Emphasis = emphasis;
            this.ExclamationMarks = exclamationMarks;
            this.ExplanatoryNoteIndicator = explanatoryNoteIndicator;
            this.FullSentenceInRoundBrackets = fullSentenceInRoundBrackets;
            this.HighlightingSpecificExpressions = highlightingSpecificExpressions;
            this.JapaneseReferenceMaterials = japaneseReferenceMaterials;
            this.ParenthesesForSupplementaryInformation = parenthesesForSupplementaryInformation;
            this.PassageOfTimeAndMovementBetweenLocations = passageOfTimeAndMovementBetweenLocations;
            this.PeriodsAndCommas = periodsAndCommas;
            this.PeriodsInAcademicDegrees = periodsInAcademicDegrees;
            this.PeriodsInDirectQuotes = periodsInDirectQuotes;
            this.PeriodsInUppercaseInitialismsAndAcronyms = periodsInUppercaseInitialismsAndAcronyms;
            this.PlusSignUsage = plusSignUsage;
            this.PossessivesOfProperNamesEndingInSStyle = possessivesOfProperNamesEndingInSStyle;
            this.QuotationMark = quotationMark;
            this.QuotationMarkAndApostrophe = quotationMarkAndApostrophe;
            this.QuotationStyle = quotationStyle;
            this.RangeIndicator = rangeIndicator;
            this.RelatedPhrasesIndicator = relatedPhrasesIndicator;
            this.RoundBrackets = roundBrackets;
            this.Salutation = salutation;
            this.SentenceBreakIndicator = sentenceBreakIndicator;
            this.SerialComma = serialComma;
            this.SettingOffNonQuotedPhrases = settingOffNonQuotedPhrases;
            this.Slash = slash;
            this.SlashUsage = slashUsage;
            this.SpacingAndPunctuation = spacingAndPunctuation;
            this.TextInRoundBracketsReferringToPreviousSentence = textInRoundBracketsReferringToPreviousSentence;
            this.TextInRoundBracketsSupplementingPrecedingText = textInRoundBracketsSupplementingPrecedingText;
            this.TitlesOfBooksAndNewspapers = titlesOfBooksAndNewspapers;
            this.TitlesOfCreativeWorksTradeNamesLawsAndRegulations = titlesOfCreativeWorksTradeNamesLawsAndRegulations;
            this.UppercaseAcronyms = uppercaseAcronyms;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfiguredRulesPunctuation" /> class.
        /// </summary>
        public ConfiguredRulesPunctuation()
        {
        }
    }
}