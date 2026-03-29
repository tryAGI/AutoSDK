//HintName: G.Models.GuardrailCheckId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Identifier of the guardrail check type
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GuardrailCheckId
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="acuvity.scan")]
        AcuvityScan,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="aporia.validateProject")]
        AporiaValidateProject,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="azure.contentSafety")]
        AzureContentSafety,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="azure.pii")]
        AzurePii,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bedrock.guard")]
        BedrockGuard,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default.allowedRequestTypes")]
        DefaultAllowedRequestTypes,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default.alluppercase")]
        DefaultAlluppercase,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default.characterCount")]
        DefaultCharacterCount,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default.contains")]
        DefaultContains,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default.containsCode")]
        DefaultContainsCode,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default.endsWith")]
        DefaultEndsWith,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default.isAllLowerCase")]
        DefaultIsAllLowerCase,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default.jsonKeys")]
        DefaultJsonKeys,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default.jsonSchema")]
        DefaultJsonSchema,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default.jwt")]
        DefaultJwt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default.modelWhitelist")]
        DefaultModelWhitelist,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default.regexMatch")]
        DefaultRegexMatch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default.requiredMetadataKeys")]
        DefaultRequiredMetadataKeys,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default.sentenceCount")]
        DefaultSentenceCount,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default.validUrls")]
        DefaultValidUrls,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default.webhook")]
        DefaultWebhook,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default.wordCount")]
        DefaultWordCount,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lasso.classify")]
        LassoClassify,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mistral.moderateContent")]
        MistralModerateContent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="panw-prisma-airs.intercept")]
        PanwPrismaAirsIntercept,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="patronus.custom")]
        PatronusCustom,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="patronus.isConcise")]
        PatronusIsConcise,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="patronus.isHelpful")]
        PatronusIsHelpful,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="patronus.isPolite")]
        PatronusIsPolite,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="patronus.noApologies")]
        PatronusNoApologies,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="patronus.noGenderBias")]
        PatronusNoGenderBias,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="patronus.noRacialBias")]
        PatronusNoRacialBias,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="patronus.phi")]
        PatronusPhi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="patronus.pii")]
        PatronusPii,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="patronus.retrievalAnswerRelevance")]
        PatronusRetrievalAnswerRelevance,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="patronus.toxicity")]
        PatronusToxicity,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pillar.scanPrompt")]
        PillarScanPrompt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pillar.scanResponse")]
        PillarScanResponse,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="portkey.gibberish")]
        PortkeyGibberish,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="portkey.language")]
        PortkeyLanguage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="portkey.moderateContent")]
        PortkeyModerateContent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="portkey.pii")]
        PortkeyPii,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="promptfoo.guard")]
        PromptfooGuard,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="promptfoo.harm")]
        PromptfooHarm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="promptfoo.pii")]
        PromptfooPii,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sydelabs.sydeguard")]
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