//HintName: G.Models.CreateAssistantDTOCredentialDiscriminatorProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateAssistantDTOCredentialDiscriminatorProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Anthropic,
        /// <summary>
        /// 
        /// </summary>
        AnthropicBedrock,
        /// <summary>
        /// 
        /// </summary>
        Anyscale,
        /// <summary>
        /// 
        /// </summary>
        AssemblyAi,
        /// <summary>
        /// 
        /// </summary>
        Azure,
        /// <summary>
        /// 
        /// </summary>
        AzureOpenai,
        /// <summary>
        /// 
        /// </summary>
        ByoSipTrunk,
        /// <summary>
        /// 
        /// </summary>
        Cartesia,
        /// <summary>
        /// 
        /// </summary>
        Cerebras,
        /// <summary>
        /// 
        /// </summary>
        Cloudflare,
        /// <summary>
        /// 
        /// </summary>
        CustomCredential,
        /// <summary>
        /// 
        /// </summary>
        CustomLlm,
        /// <summary>
        /// 
        /// </summary>
        DeepSeek,
        /// <summary>
        /// 
        /// </summary>
        Deepgram,
        /// <summary>
        /// 
        /// </summary>
        Deepinfra,
        /// <summary>
        /// 
        /// </summary>
        Elevenlabs,
        /// <summary>
        /// 
        /// </summary>
        Email,
        /// <summary>
        /// 
        /// </summary>
        Gcp,
        /// <summary>
        /// 
        /// </summary>
        GhlOauth2Authorization,
        /// <summary>
        /// 
        /// </summary>
        Gladia,
        /// <summary>
        /// 
        /// </summary>
        Gohighlevel,
        /// <summary>
        /// 
        /// </summary>
        Google,
        /// <summary>
        /// 
        /// </summary>
        GoogleCalendarOauth2Authorization,
        /// <summary>
        /// 
        /// </summary>
        GoogleCalendarOauth2Client,
        /// <summary>
        /// 
        /// </summary>
        GoogleSheetsOauth2Authorization,
        /// <summary>
        /// 
        /// </summary>
        Groq,
        /// <summary>
        /// 
        /// </summary>
        Hume,
        /// <summary>
        /// 
        /// </summary>
        InflectionAi,
        /// <summary>
        /// 
        /// </summary>
        Inworld,
        /// <summary>
        /// 
        /// </summary>
        Langfuse,
        /// <summary>
        /// 
        /// </summary>
        Lmnt,
        /// <summary>
        /// 
        /// </summary>
        Make,
        /// <summary>
        /// 
        /// </summary>
        Minimax,
        /// <summary>
        /// 
        /// </summary>
        Mistral,
        /// <summary>
        /// 
        /// </summary>
        Neuphonic,
        /// <summary>
        /// 
        /// </summary>
        Openai,
        /// <summary>
        /// 
        /// </summary>
        Openrouter,
        /// <summary>
        /// 
        /// </summary>
        PerplexityAi,
        /// <summary>
        /// 
        /// </summary>
        Playht,
        /// <summary>
        /// 
        /// </summary>
        RimeAi,
        /// <summary>
        /// 
        /// </summary>
        Runpod,
        /// <summary>
        /// 
        /// </summary>
        S3,
        /// <summary>
        /// 
        /// </summary>
        SlackWebhook,
        /// <summary>
        /// 
        /// </summary>
        SlackOauth2Authorization,
        /// <summary>
        /// 
        /// </summary>
        SmallestAi,
        /// <summary>
        /// 
        /// </summary>
        Soniox,
        /// <summary>
        /// 
        /// </summary>
        Speechmatics,
        /// <summary>
        /// 
        /// </summary>
        Supabase,
        /// <summary>
        /// 
        /// </summary>
        Tavus,
        /// <summary>
        /// 
        /// </summary>
        TogetherAi,
        /// <summary>
        /// 
        /// </summary>
        Trieve,
        /// <summary>
        /// 
        /// </summary>
        Twilio,
        /// <summary>
        /// 
        /// </summary>
        Vonage,
        /// <summary>
        /// 
        /// </summary>
        Webhook,
        /// <summary>
        /// 
        /// </summary>
        Wellsaid,
        /// <summary>
        /// 
        /// </summary>
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