//HintName: G.Models.CreateWorkflowDTOCredentialDiscriminatorProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateWorkflowDTOCredentialDiscriminatorProvider
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
    public static class CreateWorkflowDTOCredentialDiscriminatorProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWorkflowDTOCredentialDiscriminatorProvider value)
        {
            return value switch
            {
                CreateWorkflowDTOCredentialDiscriminatorProvider.Anthropic => "anthropic",
                CreateWorkflowDTOCredentialDiscriminatorProvider.AnthropicBedrock => "anthropic-bedrock",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Anyscale => "anyscale",
                CreateWorkflowDTOCredentialDiscriminatorProvider.AssemblyAi => "assembly-ai",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Azure => "azure",
                CreateWorkflowDTOCredentialDiscriminatorProvider.AzureOpenai => "azure-openai",
                CreateWorkflowDTOCredentialDiscriminatorProvider.ByoSipTrunk => "byo-sip-trunk",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Cartesia => "cartesia",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Cerebras => "cerebras",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Cloudflare => "cloudflare",
                CreateWorkflowDTOCredentialDiscriminatorProvider.CustomCredential => "custom-credential",
                CreateWorkflowDTOCredentialDiscriminatorProvider.CustomLlm => "custom-llm",
                CreateWorkflowDTOCredentialDiscriminatorProvider.DeepSeek => "deep-seek",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Deepgram => "deepgram",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Deepinfra => "deepinfra",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Elevenlabs => "elevenlabs",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Email => "email",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Gcp => "gcp",
                CreateWorkflowDTOCredentialDiscriminatorProvider.GhlOauth2Authorization => "ghl.oauth2-authorization",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Gladia => "gladia",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Gohighlevel => "gohighlevel",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Google => "google",
                CreateWorkflowDTOCredentialDiscriminatorProvider.GoogleCalendarOauth2Authorization => "google.calendar.oauth2-authorization",
                CreateWorkflowDTOCredentialDiscriminatorProvider.GoogleCalendarOauth2Client => "google.calendar.oauth2-client",
                CreateWorkflowDTOCredentialDiscriminatorProvider.GoogleSheetsOauth2Authorization => "google.sheets.oauth2-authorization",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Groq => "groq",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Hume => "hume",
                CreateWorkflowDTOCredentialDiscriminatorProvider.InflectionAi => "inflection-ai",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Inworld => "inworld",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Langfuse => "langfuse",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Lmnt => "lmnt",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Make => "make",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Minimax => "minimax",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Mistral => "mistral",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Neuphonic => "neuphonic",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Openai => "openai",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Openrouter => "openrouter",
                CreateWorkflowDTOCredentialDiscriminatorProvider.PerplexityAi => "perplexity-ai",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Playht => "playht",
                CreateWorkflowDTOCredentialDiscriminatorProvider.RimeAi => "rime-ai",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Runpod => "runpod",
                CreateWorkflowDTOCredentialDiscriminatorProvider.S3 => "s3",
                CreateWorkflowDTOCredentialDiscriminatorProvider.SlackWebhook => "slack-webhook",
                CreateWorkflowDTOCredentialDiscriminatorProvider.SlackOauth2Authorization => "slack.oauth2-authorization",
                CreateWorkflowDTOCredentialDiscriminatorProvider.SmallestAi => "smallest-ai",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Soniox => "soniox",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Speechmatics => "speechmatics",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Supabase => "supabase",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Tavus => "tavus",
                CreateWorkflowDTOCredentialDiscriminatorProvider.TogetherAi => "together-ai",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Trieve => "trieve",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Twilio => "twilio",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Vonage => "vonage",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Webhook => "webhook",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Wellsaid => "wellsaid",
                CreateWorkflowDTOCredentialDiscriminatorProvider.Xai => "xai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWorkflowDTOCredentialDiscriminatorProvider? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => CreateWorkflowDTOCredentialDiscriminatorProvider.Anthropic,
                "anthropic-bedrock" => CreateWorkflowDTOCredentialDiscriminatorProvider.AnthropicBedrock,
                "anyscale" => CreateWorkflowDTOCredentialDiscriminatorProvider.Anyscale,
                "assembly-ai" => CreateWorkflowDTOCredentialDiscriminatorProvider.AssemblyAi,
                "azure" => CreateWorkflowDTOCredentialDiscriminatorProvider.Azure,
                "azure-openai" => CreateWorkflowDTOCredentialDiscriminatorProvider.AzureOpenai,
                "byo-sip-trunk" => CreateWorkflowDTOCredentialDiscriminatorProvider.ByoSipTrunk,
                "cartesia" => CreateWorkflowDTOCredentialDiscriminatorProvider.Cartesia,
                "cerebras" => CreateWorkflowDTOCredentialDiscriminatorProvider.Cerebras,
                "cloudflare" => CreateWorkflowDTOCredentialDiscriminatorProvider.Cloudflare,
                "custom-credential" => CreateWorkflowDTOCredentialDiscriminatorProvider.CustomCredential,
                "custom-llm" => CreateWorkflowDTOCredentialDiscriminatorProvider.CustomLlm,
                "deep-seek" => CreateWorkflowDTOCredentialDiscriminatorProvider.DeepSeek,
                "deepgram" => CreateWorkflowDTOCredentialDiscriminatorProvider.Deepgram,
                "deepinfra" => CreateWorkflowDTOCredentialDiscriminatorProvider.Deepinfra,
                "elevenlabs" => CreateWorkflowDTOCredentialDiscriminatorProvider.Elevenlabs,
                "email" => CreateWorkflowDTOCredentialDiscriminatorProvider.Email,
                "gcp" => CreateWorkflowDTOCredentialDiscriminatorProvider.Gcp,
                "ghl.oauth2-authorization" => CreateWorkflowDTOCredentialDiscriminatorProvider.GhlOauth2Authorization,
                "gladia" => CreateWorkflowDTOCredentialDiscriminatorProvider.Gladia,
                "gohighlevel" => CreateWorkflowDTOCredentialDiscriminatorProvider.Gohighlevel,
                "google" => CreateWorkflowDTOCredentialDiscriminatorProvider.Google,
                "google.calendar.oauth2-authorization" => CreateWorkflowDTOCredentialDiscriminatorProvider.GoogleCalendarOauth2Authorization,
                "google.calendar.oauth2-client" => CreateWorkflowDTOCredentialDiscriminatorProvider.GoogleCalendarOauth2Client,
                "google.sheets.oauth2-authorization" => CreateWorkflowDTOCredentialDiscriminatorProvider.GoogleSheetsOauth2Authorization,
                "groq" => CreateWorkflowDTOCredentialDiscriminatorProvider.Groq,
                "hume" => CreateWorkflowDTOCredentialDiscriminatorProvider.Hume,
                "inflection-ai" => CreateWorkflowDTOCredentialDiscriminatorProvider.InflectionAi,
                "inworld" => CreateWorkflowDTOCredentialDiscriminatorProvider.Inworld,
                "langfuse" => CreateWorkflowDTOCredentialDiscriminatorProvider.Langfuse,
                "lmnt" => CreateWorkflowDTOCredentialDiscriminatorProvider.Lmnt,
                "make" => CreateWorkflowDTOCredentialDiscriminatorProvider.Make,
                "minimax" => CreateWorkflowDTOCredentialDiscriminatorProvider.Minimax,
                "mistral" => CreateWorkflowDTOCredentialDiscriminatorProvider.Mistral,
                "neuphonic" => CreateWorkflowDTOCredentialDiscriminatorProvider.Neuphonic,
                "openai" => CreateWorkflowDTOCredentialDiscriminatorProvider.Openai,
                "openrouter" => CreateWorkflowDTOCredentialDiscriminatorProvider.Openrouter,
                "perplexity-ai" => CreateWorkflowDTOCredentialDiscriminatorProvider.PerplexityAi,
                "playht" => CreateWorkflowDTOCredentialDiscriminatorProvider.Playht,
                "rime-ai" => CreateWorkflowDTOCredentialDiscriminatorProvider.RimeAi,
                "runpod" => CreateWorkflowDTOCredentialDiscriminatorProvider.Runpod,
                "s3" => CreateWorkflowDTOCredentialDiscriminatorProvider.S3,
                "slack-webhook" => CreateWorkflowDTOCredentialDiscriminatorProvider.SlackWebhook,
                "slack.oauth2-authorization" => CreateWorkflowDTOCredentialDiscriminatorProvider.SlackOauth2Authorization,
                "smallest-ai" => CreateWorkflowDTOCredentialDiscriminatorProvider.SmallestAi,
                "soniox" => CreateWorkflowDTOCredentialDiscriminatorProvider.Soniox,
                "speechmatics" => CreateWorkflowDTOCredentialDiscriminatorProvider.Speechmatics,
                "supabase" => CreateWorkflowDTOCredentialDiscriminatorProvider.Supabase,
                "tavus" => CreateWorkflowDTOCredentialDiscriminatorProvider.Tavus,
                "together-ai" => CreateWorkflowDTOCredentialDiscriminatorProvider.TogetherAi,
                "trieve" => CreateWorkflowDTOCredentialDiscriminatorProvider.Trieve,
                "twilio" => CreateWorkflowDTOCredentialDiscriminatorProvider.Twilio,
                "vonage" => CreateWorkflowDTOCredentialDiscriminatorProvider.Vonage,
                "webhook" => CreateWorkflowDTOCredentialDiscriminatorProvider.Webhook,
                "wellsaid" => CreateWorkflowDTOCredentialDiscriminatorProvider.Wellsaid,
                "xai" => CreateWorkflowDTOCredentialDiscriminatorProvider.Xai,
                _ => null,
            };
        }
    }
}