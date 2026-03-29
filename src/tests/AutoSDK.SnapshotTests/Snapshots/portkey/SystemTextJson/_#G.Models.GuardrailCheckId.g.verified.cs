//HintName: G.Models.GuardrailCheckId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Identifier of the guardrail check type
    /// </summary>
    public enum GuardrailCheckId
    {
        /// <summary>
        /// 
        /// </summary>
        AcuvityScan,
        /// <summary>
        /// 
        /// </summary>
        AporiaValidateProject,
        /// <summary>
        /// 
        /// </summary>
        AzureContentSafety,
        /// <summary>
        /// 
        /// </summary>
        AzurePii,
        /// <summary>
        /// 
        /// </summary>
        BedrockGuard,
        /// <summary>
        /// 
        /// </summary>
        DefaultAllowedRequestTypes,
        /// <summary>
        /// 
        /// </summary>
        DefaultAlluppercase,
        /// <summary>
        /// 
        /// </summary>
        DefaultCharacterCount,
        /// <summary>
        /// 
        /// </summary>
        DefaultContains,
        /// <summary>
        /// 
        /// </summary>
        DefaultContainsCode,
        /// <summary>
        /// 
        /// </summary>
        DefaultEndsWith,
        /// <summary>
        /// 
        /// </summary>
        DefaultIsAllLowerCase,
        /// <summary>
        /// 
        /// </summary>
        DefaultJsonKeys,
        /// <summary>
        /// 
        /// </summary>
        DefaultJsonSchema,
        /// <summary>
        /// 
        /// </summary>
        DefaultJwt,
        /// <summary>
        /// 
        /// </summary>
        DefaultModelWhitelist,
        /// <summary>
        /// 
        /// </summary>
        DefaultRegexMatch,
        /// <summary>
        /// 
        /// </summary>
        DefaultRequiredMetadataKeys,
        /// <summary>
        /// 
        /// </summary>
        DefaultSentenceCount,
        /// <summary>
        /// 
        /// </summary>
        DefaultValidUrls,
        /// <summary>
        /// 
        /// </summary>
        DefaultWebhook,
        /// <summary>
        /// 
        /// </summary>
        DefaultWordCount,
        /// <summary>
        /// 
        /// </summary>
        LassoClassify,
        /// <summary>
        /// 
        /// </summary>
        MistralModerateContent,
        /// <summary>
        /// 
        /// </summary>
        PanwPrismaAirsIntercept,
        /// <summary>
        /// 
        /// </summary>
        PatronusCustom,
        /// <summary>
        /// 
        /// </summary>
        PatronusIsConcise,
        /// <summary>
        /// 
        /// </summary>
        PatronusIsHelpful,
        /// <summary>
        /// 
        /// </summary>
        PatronusIsPolite,
        /// <summary>
        /// 
        /// </summary>
        PatronusNoApologies,
        /// <summary>
        /// 
        /// </summary>
        PatronusNoGenderBias,
        /// <summary>
        /// 
        /// </summary>
        PatronusNoRacialBias,
        /// <summary>
        /// 
        /// </summary>
        PatronusPhi,
        /// <summary>
        /// 
        /// </summary>
        PatronusPii,
        /// <summary>
        /// 
        /// </summary>
        PatronusRetrievalAnswerRelevance,
        /// <summary>
        /// 
        /// </summary>
        PatronusToxicity,
        /// <summary>
        /// 
        /// </summary>
        PillarScanPrompt,
        /// <summary>
        /// 
        /// </summary>
        PillarScanResponse,
        /// <summary>
        /// 
        /// </summary>
        PortkeyGibberish,
        /// <summary>
        /// 
        /// </summary>
        PortkeyLanguage,
        /// <summary>
        /// 
        /// </summary>
        PortkeyModerateContent,
        /// <summary>
        /// 
        /// </summary>
        PortkeyPii,
        /// <summary>
        /// 
        /// </summary>
        PromptfooGuard,
        /// <summary>
        /// 
        /// </summary>
        PromptfooHarm,
        /// <summary>
        /// 
        /// </summary>
        PromptfooPii,
        /// <summary>
        /// 
        /// </summary>
        SydelabsSydeguard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GuardrailCheckIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailCheckId value)
        {
            return value switch
            {
                GuardrailCheckId.AcuvityScan => "acuvity.scan",
                GuardrailCheckId.AporiaValidateProject => "aporia.validateProject",
                GuardrailCheckId.AzureContentSafety => "azure.contentSafety",
                GuardrailCheckId.AzurePii => "azure.pii",
                GuardrailCheckId.BedrockGuard => "bedrock.guard",
                GuardrailCheckId.DefaultAllowedRequestTypes => "default.allowedRequestTypes",
                GuardrailCheckId.DefaultAlluppercase => "default.alluppercase",
                GuardrailCheckId.DefaultCharacterCount => "default.characterCount",
                GuardrailCheckId.DefaultContains => "default.contains",
                GuardrailCheckId.DefaultContainsCode => "default.containsCode",
                GuardrailCheckId.DefaultEndsWith => "default.endsWith",
                GuardrailCheckId.DefaultIsAllLowerCase => "default.isAllLowerCase",
                GuardrailCheckId.DefaultJsonKeys => "default.jsonKeys",
                GuardrailCheckId.DefaultJsonSchema => "default.jsonSchema",
                GuardrailCheckId.DefaultJwt => "default.jwt",
                GuardrailCheckId.DefaultModelWhitelist => "default.modelWhitelist",
                GuardrailCheckId.DefaultRegexMatch => "default.regexMatch",
                GuardrailCheckId.DefaultRequiredMetadataKeys => "default.requiredMetadataKeys",
                GuardrailCheckId.DefaultSentenceCount => "default.sentenceCount",
                GuardrailCheckId.DefaultValidUrls => "default.validUrls",
                GuardrailCheckId.DefaultWebhook => "default.webhook",
                GuardrailCheckId.DefaultWordCount => "default.wordCount",
                GuardrailCheckId.LassoClassify => "lasso.classify",
                GuardrailCheckId.MistralModerateContent => "mistral.moderateContent",
                GuardrailCheckId.PanwPrismaAirsIntercept => "panw-prisma-airs.intercept",
                GuardrailCheckId.PatronusCustom => "patronus.custom",
                GuardrailCheckId.PatronusIsConcise => "patronus.isConcise",
                GuardrailCheckId.PatronusIsHelpful => "patronus.isHelpful",
                GuardrailCheckId.PatronusIsPolite => "patronus.isPolite",
                GuardrailCheckId.PatronusNoApologies => "patronus.noApologies",
                GuardrailCheckId.PatronusNoGenderBias => "patronus.noGenderBias",
                GuardrailCheckId.PatronusNoRacialBias => "patronus.noRacialBias",
                GuardrailCheckId.PatronusPhi => "patronus.phi",
                GuardrailCheckId.PatronusPii => "patronus.pii",
                GuardrailCheckId.PatronusRetrievalAnswerRelevance => "patronus.retrievalAnswerRelevance",
                GuardrailCheckId.PatronusToxicity => "patronus.toxicity",
                GuardrailCheckId.PillarScanPrompt => "pillar.scanPrompt",
                GuardrailCheckId.PillarScanResponse => "pillar.scanResponse",
                GuardrailCheckId.PortkeyGibberish => "portkey.gibberish",
                GuardrailCheckId.PortkeyLanguage => "portkey.language",
                GuardrailCheckId.PortkeyModerateContent => "portkey.moderateContent",
                GuardrailCheckId.PortkeyPii => "portkey.pii",
                GuardrailCheckId.PromptfooGuard => "promptfoo.guard",
                GuardrailCheckId.PromptfooHarm => "promptfoo.harm",
                GuardrailCheckId.PromptfooPii => "promptfoo.pii",
                GuardrailCheckId.SydelabsSydeguard => "sydelabs.sydeguard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailCheckId? ToEnum(string value)
        {
            return value switch
            {
                "acuvity.scan" => GuardrailCheckId.AcuvityScan,
                "aporia.validateProject" => GuardrailCheckId.AporiaValidateProject,
                "azure.contentSafety" => GuardrailCheckId.AzureContentSafety,
                "azure.pii" => GuardrailCheckId.AzurePii,
                "bedrock.guard" => GuardrailCheckId.BedrockGuard,
                "default.allowedRequestTypes" => GuardrailCheckId.DefaultAllowedRequestTypes,
                "default.alluppercase" => GuardrailCheckId.DefaultAlluppercase,
                "default.characterCount" => GuardrailCheckId.DefaultCharacterCount,
                "default.contains" => GuardrailCheckId.DefaultContains,
                "default.containsCode" => GuardrailCheckId.DefaultContainsCode,
                "default.endsWith" => GuardrailCheckId.DefaultEndsWith,
                "default.isAllLowerCase" => GuardrailCheckId.DefaultIsAllLowerCase,
                "default.jsonKeys" => GuardrailCheckId.DefaultJsonKeys,
                "default.jsonSchema" => GuardrailCheckId.DefaultJsonSchema,
                "default.jwt" => GuardrailCheckId.DefaultJwt,
                "default.modelWhitelist" => GuardrailCheckId.DefaultModelWhitelist,
                "default.regexMatch" => GuardrailCheckId.DefaultRegexMatch,
                "default.requiredMetadataKeys" => GuardrailCheckId.DefaultRequiredMetadataKeys,
                "default.sentenceCount" => GuardrailCheckId.DefaultSentenceCount,
                "default.validUrls" => GuardrailCheckId.DefaultValidUrls,
                "default.webhook" => GuardrailCheckId.DefaultWebhook,
                "default.wordCount" => GuardrailCheckId.DefaultWordCount,
                "lasso.classify" => GuardrailCheckId.LassoClassify,
                "mistral.moderateContent" => GuardrailCheckId.MistralModerateContent,
                "panw-prisma-airs.intercept" => GuardrailCheckId.PanwPrismaAirsIntercept,
                "patronus.custom" => GuardrailCheckId.PatronusCustom,
                "patronus.isConcise" => GuardrailCheckId.PatronusIsConcise,
                "patronus.isHelpful" => GuardrailCheckId.PatronusIsHelpful,
                "patronus.isPolite" => GuardrailCheckId.PatronusIsPolite,
                "patronus.noApologies" => GuardrailCheckId.PatronusNoApologies,
                "patronus.noGenderBias" => GuardrailCheckId.PatronusNoGenderBias,
                "patronus.noRacialBias" => GuardrailCheckId.PatronusNoRacialBias,
                "patronus.phi" => GuardrailCheckId.PatronusPhi,
                "patronus.pii" => GuardrailCheckId.PatronusPii,
                "patronus.retrievalAnswerRelevance" => GuardrailCheckId.PatronusRetrievalAnswerRelevance,
                "patronus.toxicity" => GuardrailCheckId.PatronusToxicity,
                "pillar.scanPrompt" => GuardrailCheckId.PillarScanPrompt,
                "pillar.scanResponse" => GuardrailCheckId.PillarScanResponse,
                "portkey.gibberish" => GuardrailCheckId.PortkeyGibberish,
                "portkey.language" => GuardrailCheckId.PortkeyLanguage,
                "portkey.moderateContent" => GuardrailCheckId.PortkeyModerateContent,
                "portkey.pii" => GuardrailCheckId.PortkeyPii,
                "promptfoo.guard" => GuardrailCheckId.PromptfooGuard,
                "promptfoo.harm" => GuardrailCheckId.PromptfooHarm,
                "promptfoo.pii" => GuardrailCheckId.PromptfooPii,
                "sydelabs.sydeguard" => GuardrailCheckId.SydelabsSydeguard,
                _ => null,
            };
        }
    }
}