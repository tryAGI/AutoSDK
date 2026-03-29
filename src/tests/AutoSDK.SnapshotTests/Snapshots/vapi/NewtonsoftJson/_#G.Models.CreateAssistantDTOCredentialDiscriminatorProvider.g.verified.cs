//HintName: G.Models.CreateAssistantDTOCredentialDiscriminatorProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateAssistantDTOCredentialDiscriminatorProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="anthropic")]
        Anthropic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="anthropic-bedrock")]
        AnthropicBedrock,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="anyscale")]
        Anyscale,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assembly-ai")]
        AssemblyAi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="azure")]
        Azure,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="azure-openai")]
        AzureOpenai,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="byo-sip-trunk")]
        ByoSipTrunk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cartesia")]
        Cartesia,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cerebras")]
        Cerebras,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cloudflare")]
        Cloudflare,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="custom-credential")]
        CustomCredential,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="custom-llm")]
        CustomLlm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deep-seek")]
        DeepSeek,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deepgram")]
        Deepgram,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deepinfra")]
        Deepinfra,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="elevenlabs")]
        Elevenlabs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="email")]
        Email,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gcp")]
        Gcp,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ghl.oauth2-authorization")]
        GhlOauth2Authorization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gladia")]
        Gladia,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gohighlevel")]
        Gohighlevel,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="google")]
        Google,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="google.calendar.oauth2-authorization")]
        GoogleCalendarOauth2Authorization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="google.calendar.oauth2-client")]
        GoogleCalendarOauth2Client,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="google.sheets.oauth2-authorization")]
        GoogleSheetsOauth2Authorization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="groq")]
        Groq,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hume")]
        Hume,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="inflection-ai")]
        InflectionAi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="inworld")]
        Inworld,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="langfuse")]
        Langfuse,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lmnt")]
        Lmnt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="make")]
        Make,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="minimax")]
        Minimax,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mistral")]
        Mistral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="neuphonic")]
        Neuphonic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openai")]
        Openai,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openrouter")]
        Openrouter,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="perplexity-ai")]
        PerplexityAi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="playht")]
        Playht,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rime-ai")]
        RimeAi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="runpod")]
        Runpod,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="s3")]
        S3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="slack-webhook")]
        SlackWebhook,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="slack.oauth2-authorization")]
        SlackOauth2Authorization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="smallest-ai")]
        SmallestAi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="soniox")]
        Soniox,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="speechmatics")]
        Speechmatics,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="supabase")]
        Supabase,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tavus")]
        Tavus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="together-ai")]
        TogetherAi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="trieve")]
        Trieve,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="twilio")]
        Twilio,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vonage")]
        Vonage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="webhook")]
        Webhook,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="wellsaid")]
        Wellsaid,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="xai")]
        Xai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAssistantDTOCredentialDiscriminatorProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssistantDTOCredentialDiscriminatorProvider value)
        {
            return value switch
            {
                CreateAssistantDTOCredentialDiscriminatorProvider.Anthropic => "anthropic",
                CreateAssistantDTOCredentialDiscriminatorProvider.AnthropicBedrock => "anthropic-bedrock",
                CreateAssistantDTOCredentialDiscriminatorProvider.Anyscale => "anyscale",
                CreateAssistantDTOCredentialDiscriminatorProvider.AssemblyAi => "assembly-ai",
                CreateAssistantDTOCredentialDiscriminatorProvider.Azure => "azure",
                CreateAssistantDTOCredentialDiscriminatorProvider.AzureOpenai => "azure-openai",
                CreateAssistantDTOCredentialDiscriminatorProvider.ByoSipTrunk => "byo-sip-trunk",
                CreateAssistantDTOCredentialDiscriminatorProvider.Cartesia => "cartesia",
                CreateAssistantDTOCredentialDiscriminatorProvider.Cerebras => "cerebras",
                CreateAssistantDTOCredentialDiscriminatorProvider.Cloudflare => "cloudflare",
                CreateAssistantDTOCredentialDiscriminatorProvider.CustomCredential => "custom-credential",
                CreateAssistantDTOCredentialDiscriminatorProvider.CustomLlm => "custom-llm",
                CreateAssistantDTOCredentialDiscriminatorProvider.DeepSeek => "deep-seek",
                CreateAssistantDTOCredentialDiscriminatorProvider.Deepgram => "deepgram",
                CreateAssistantDTOCredentialDiscriminatorProvider.Deepinfra => "deepinfra",
                CreateAssistantDTOCredentialDiscriminatorProvider.Elevenlabs => "elevenlabs",
                CreateAssistantDTOCredentialDiscriminatorProvider.Email => "email",
                CreateAssistantDTOCredentialDiscriminatorProvider.Gcp => "gcp",
                CreateAssistantDTOCredentialDiscriminatorProvider.GhlOauth2Authorization => "ghl.oauth2-authorization",
                CreateAssistantDTOCredentialDiscriminatorProvider.Gladia => "gladia",
                CreateAssistantDTOCredentialDiscriminatorProvider.Gohighlevel => "gohighlevel",
                CreateAssistantDTOCredentialDiscriminatorProvider.Google => "google",
                CreateAssistantDTOCredentialDiscriminatorProvider.GoogleCalendarOauth2Authorization => "google.calendar.oauth2-authorization",
                CreateAssistantDTOCredentialDiscriminatorProvider.GoogleCalendarOauth2Client => "google.calendar.oauth2-client",
                CreateAssistantDTOCredentialDiscriminatorProvider.GoogleSheetsOauth2Authorization => "google.sheets.oauth2-authorization",
                CreateAssistantDTOCredentialDiscriminatorProvider.Groq => "groq",
                CreateAssistantDTOCredentialDiscriminatorProvider.Hume => "hume",
                CreateAssistantDTOCredentialDiscriminatorProvider.InflectionAi => "inflection-ai",
                CreateAssistantDTOCredentialDiscriminatorProvider.Inworld => "inworld",
                CreateAssistantDTOCredentialDiscriminatorProvider.Langfuse => "langfuse",
                CreateAssistantDTOCredentialDiscriminatorProvider.Lmnt => "lmnt",
                CreateAssistantDTOCredentialDiscriminatorProvider.Make => "make",
                CreateAssistantDTOCredentialDiscriminatorProvider.Minimax => "minimax",
                CreateAssistantDTOCredentialDiscriminatorProvider.Mistral => "mistral",
                CreateAssistantDTOCredentialDiscriminatorProvider.Neuphonic => "neuphonic",
                CreateAssistantDTOCredentialDiscriminatorProvider.Openai => "openai",
                CreateAssistantDTOCredentialDiscriminatorProvider.Openrouter => "openrouter",
                CreateAssistantDTOCredentialDiscriminatorProvider.PerplexityAi => "perplexity-ai",
                CreateAssistantDTOCredentialDiscriminatorProvider.Playht => "playht",
                CreateAssistantDTOCredentialDiscriminatorProvider.RimeAi => "rime-ai",
                CreateAssistantDTOCredentialDiscriminatorProvider.Runpod => "runpod",
                CreateAssistantDTOCredentialDiscriminatorProvider.S3 => "s3",
                CreateAssistantDTOCredentialDiscriminatorProvider.SlackWebhook => "slack-webhook",
                CreateAssistantDTOCredentialDiscriminatorProvider.SlackOauth2Authorization => "slack.oauth2-authorization",
                CreateAssistantDTOCredentialDiscriminatorProvider.SmallestAi => "smallest-ai",
                CreateAssistantDTOCredentialDiscriminatorProvider.Soniox => "soniox",
                CreateAssistantDTOCredentialDiscriminatorProvider.Speechmatics => "speechmatics",
                CreateAssistantDTOCredentialDiscriminatorProvider.Supabase => "supabase",
                CreateAssistantDTOCredentialDiscriminatorProvider.Tavus => "tavus",
                CreateAssistantDTOCredentialDiscriminatorProvider.TogetherAi => "together-ai",
                CreateAssistantDTOCredentialDiscriminatorProvider.Trieve => "trieve",
                CreateAssistantDTOCredentialDiscriminatorProvider.Twilio => "twilio",
                CreateAssistantDTOCredentialDiscriminatorProvider.Vonage => "vonage",
                CreateAssistantDTOCredentialDiscriminatorProvider.Webhook => "webhook",
                CreateAssistantDTOCredentialDiscriminatorProvider.Wellsaid => "wellsaid",
                CreateAssistantDTOCredentialDiscriminatorProvider.Xai => "xai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssistantDTOCredentialDiscriminatorProvider? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => CreateAssistantDTOCredentialDiscriminatorProvider.Anthropic,
                "anthropic-bedrock" => CreateAssistantDTOCredentialDiscriminatorProvider.AnthropicBedrock,
                "anyscale" => CreateAssistantDTOCredentialDiscriminatorProvider.Anyscale,
                "assembly-ai" => CreateAssistantDTOCredentialDiscriminatorProvider.AssemblyAi,
                "azure" => CreateAssistantDTOCredentialDiscriminatorProvider.Azure,
                "azure-openai" => CreateAssistantDTOCredentialDiscriminatorProvider.AzureOpenai,
                "byo-sip-trunk" => CreateAssistantDTOCredentialDiscriminatorProvider.ByoSipTrunk,
                "cartesia" => CreateAssistantDTOCredentialDiscriminatorProvider.Cartesia,
                "cerebras" => CreateAssistantDTOCredentialDiscriminatorProvider.Cerebras,
                "cloudflare" => CreateAssistantDTOCredentialDiscriminatorProvider.Cloudflare,
                "custom-credential" => CreateAssistantDTOCredentialDiscriminatorProvider.CustomCredential,
                "custom-llm" => CreateAssistantDTOCredentialDiscriminatorProvider.CustomLlm,
                "deep-seek" => CreateAssistantDTOCredentialDiscriminatorProvider.DeepSeek,
                "deepgram" => CreateAssistantDTOCredentialDiscriminatorProvider.Deepgram,
                "deepinfra" => CreateAssistantDTOCredentialDiscriminatorProvider.Deepinfra,
                "elevenlabs" => CreateAssistantDTOCredentialDiscriminatorProvider.Elevenlabs,
                "email" => CreateAssistantDTOCredentialDiscriminatorProvider.Email,
                "gcp" => CreateAssistantDTOCredentialDiscriminatorProvider.Gcp,
                "ghl.oauth2-authorization" => CreateAssistantDTOCredentialDiscriminatorProvider.GhlOauth2Authorization,
                "gladia" => CreateAssistantDTOCredentialDiscriminatorProvider.Gladia,
                "gohighlevel" => CreateAssistantDTOCredentialDiscriminatorProvider.Gohighlevel,
                "google" => CreateAssistantDTOCredentialDiscriminatorProvider.Google,
                "google.calendar.oauth2-authorization" => CreateAssistantDTOCredentialDiscriminatorProvider.GoogleCalendarOauth2Authorization,
                "google.calendar.oauth2-client" => CreateAssistantDTOCredentialDiscriminatorProvider.GoogleCalendarOauth2Client,
                "google.sheets.oauth2-authorization" => CreateAssistantDTOCredentialDiscriminatorProvider.GoogleSheetsOauth2Authorization,
                "groq" => CreateAssistantDTOCredentialDiscriminatorProvider.Groq,
                "hume" => CreateAssistantDTOCredentialDiscriminatorProvider.Hume,
                "inflection-ai" => CreateAssistantDTOCredentialDiscriminatorProvider.InflectionAi,
                "inworld" => CreateAssistantDTOCredentialDiscriminatorProvider.Inworld,
                "langfuse" => CreateAssistantDTOCredentialDiscriminatorProvider.Langfuse,
                "lmnt" => CreateAssistantDTOCredentialDiscriminatorProvider.Lmnt,
                "make" => CreateAssistantDTOCredentialDiscriminatorProvider.Make,
                "minimax" => CreateAssistantDTOCredentialDiscriminatorProvider.Minimax,
                "mistral" => CreateAssistantDTOCredentialDiscriminatorProvider.Mistral,
                "neuphonic" => CreateAssistantDTOCredentialDiscriminatorProvider.Neuphonic,
                "openai" => CreateAssistantDTOCredentialDiscriminatorProvider.Openai,
                "openrouter" => CreateAssistantDTOCredentialDiscriminatorProvider.Openrouter,
                "perplexity-ai" => CreateAssistantDTOCredentialDiscriminatorProvider.PerplexityAi,
                "playht" => CreateAssistantDTOCredentialDiscriminatorProvider.Playht,
                "rime-ai" => CreateAssistantDTOCredentialDiscriminatorProvider.RimeAi,
                "runpod" => CreateAssistantDTOCredentialDiscriminatorProvider.Runpod,
                "s3" => CreateAssistantDTOCredentialDiscriminatorProvider.S3,
                "slack-webhook" => CreateAssistantDTOCredentialDiscriminatorProvider.SlackWebhook,
                "slack.oauth2-authorization" => CreateAssistantDTOCredentialDiscriminatorProvider.SlackOauth2Authorization,
                "smallest-ai" => CreateAssistantDTOCredentialDiscriminatorProvider.SmallestAi,
                "soniox" => CreateAssistantDTOCredentialDiscriminatorProvider.Soniox,
                "speechmatics" => CreateAssistantDTOCredentialDiscriminatorProvider.Speechmatics,
                "supabase" => CreateAssistantDTOCredentialDiscriminatorProvider.Supabase,
                "tavus" => CreateAssistantDTOCredentialDiscriminatorProvider.Tavus,
                "together-ai" => CreateAssistantDTOCredentialDiscriminatorProvider.TogetherAi,
                "trieve" => CreateAssistantDTOCredentialDiscriminatorProvider.Trieve,
                "twilio" => CreateAssistantDTOCredentialDiscriminatorProvider.Twilio,
                "vonage" => CreateAssistantDTOCredentialDiscriminatorProvider.Vonage,
                "webhook" => CreateAssistantDTOCredentialDiscriminatorProvider.Webhook,
                "wellsaid" => CreateAssistantDTOCredentialDiscriminatorProvider.Wellsaid,
                "xai" => CreateAssistantDTOCredentialDiscriminatorProvider.Xai,
                _ => null,
            };
        }
    }
}