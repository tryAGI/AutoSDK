//HintName: G.Models.UpdateAssistantDTOCredentialDiscriminatorProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateAssistantDTOCredentialDiscriminatorProvider
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
    public static class UpdateAssistantDTOCredentialDiscriminatorProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssistantDTOCredentialDiscriminatorProvider value)
        {
            return value switch
            {
                UpdateAssistantDTOCredentialDiscriminatorProvider.Anthropic => "anthropic",
                UpdateAssistantDTOCredentialDiscriminatorProvider.AnthropicBedrock => "anthropic-bedrock",
                UpdateAssistantDTOCredentialDiscriminatorProvider.Anyscale => "anyscale",
                UpdateAssistantDTOCredentialDiscriminatorProvider.AssemblyAi => "assembly-ai",
                UpdateAssistantDTOCredentialDiscriminatorProvider.Azure => "azure",
                UpdateAssistantDTOCredentialDiscriminatorProvider.AzureOpenai => "azure-openai",
                UpdateAssistantDTOCredentialDiscriminatorProvider.ByoSipTrunk => "byo-sip-trunk",
                UpdateAssistantDTOCredentialDiscriminatorProvider.Cartesia => "cartesia",
                UpdateAssistantDTOCredentialDiscriminatorProvider.Cerebras => "cerebras",
                UpdateAssistantDTOCredentialDiscriminatorProvider.Cloudflare => "cloudflare",
                UpdateAssistantDTOCredentialDiscriminatorProvider.CustomCredential => "custom-credential",
                UpdateAssistantDTOCredentialDiscriminatorProvider.CustomLlm => "custom-llm",
                UpdateAssistantDTOCredentialDiscriminatorProvider.DeepSeek => "deep-seek",
                UpdateAssistantDTOCredentialDiscriminatorProvider.Deepgram => "deepgram",
                UpdateAssistantDTOCredentialDiscriminatorProvider.Deepinfra => "deepinfra",
                UpdateAssistantDTOCredentialDiscriminatorProvider.Elevenlabs => "elevenlabs",
                UpdateAssistantDTOCredentialDiscriminatorProvider.Email => "email",
                UpdateAssistantDTOCredentialDiscriminatorProvider.Gcp => "gcp",
                UpdateAssistantDTOCredentialDiscriminatorProvider.GhlOauth2Authorization => "ghl.oauth2-authorization",
                UpdateAssistantDTOCredentialDiscriminatorProvider.Gladia => "gladia",
                UpdateAssistantDTOCredentialDiscriminatorProvider.Gohighlevel => "gohighlevel",
                UpdateAssistantDTOCredentialDiscriminatorProvider.Google => "google",
                UpdateAssistantDTOCredentialDiscriminatorProvider.GoogleCalendarOauth2Authorization => "google.calendar.oauth2-authorization",
                UpdateAssistantDTOCredentialDiscriminatorProvider.GoogleCalendarOauth2Client => "google.calendar.oauth2-client",
                UpdateAssistantDTOCredentialDiscriminatorProvider.GoogleSheetsOauth2Authorization => "google.sheets.oauth2-authorization",
                UpdateAssistantDTOCredentialDiscriminatorProvider.Groq => "groq",
                UpdateAssistantDTOCredentialDiscriminatorProvider.Hume => "hume",
                UpdateAssistantDTOCredentialDiscriminatorProvider.InflectionAi => "inflection-ai",
                UpdateAssistantDTOCredentialDiscriminatorProvider.Inworld => "inworld",
                UpdateAssistantDTOCredentialDiscriminatorProvider.Langfuse => "langfuse",
                UpdateAssistantDTOCredentialDiscriminatorProvider.Lmnt => "lmnt",
                UpdateAssistantDTOCredentialDiscriminatorProvider.Make => "make",
                UpdateAssistantDTOCredentialDiscriminatorProvider.Minimax => "minimax",
                UpdateAssistantDTOCredentialDiscriminatorProvider.Mistral => "mistral",
                UpdateAssistantDTOCredentialDiscriminatorProvider.Neuphonic => "neuphonic",
                UpdateAssistantDTOCredentialDiscriminatorProvider.Openai => "openai",
                UpdateAssistantDTOCredentialDiscriminatorProvider.Openrouter => "openrouter",
                UpdateAssistantDTOCredentialDiscriminatorProvider.PerplexityAi => "perplexity-ai",
                UpdateAssistantDTOCredentialDiscriminatorProvider.Playht => "playht",
                UpdateAssistantDTOCredentialDiscriminatorProvider.RimeAi => "rime-ai",
                UpdateAssistantDTOCredentialDiscriminatorProvider.Runpod => "runpod",
                UpdateAssistantDTOCredentialDiscriminatorProvider.S3 => "s3",
                UpdateAssistantDTOCredentialDiscriminatorProvider.SlackWebhook => "slack-webhook",
                UpdateAssistantDTOCredentialDiscriminatorProvider.SlackOauth2Authorization => "slack.oauth2-authorization",
                UpdateAssistantDTOCredentialDiscriminatorProvider.SmallestAi => "smallest-ai",
                UpdateAssistantDTOCredentialDiscriminatorProvider.Soniox => "soniox",
                UpdateAssistantDTOCredentialDiscriminatorProvider.Speechmatics => "speechmatics",
                UpdateAssistantDTOCredentialDiscriminatorProvider.Supabase => "supabase",
                UpdateAssistantDTOCredentialDiscriminatorProvider.Tavus => "tavus",
                UpdateAssistantDTOCredentialDiscriminatorProvider.TogetherAi => "together-ai",
                UpdateAssistantDTOCredentialDiscriminatorProvider.Trieve => "trieve",
                UpdateAssistantDTOCredentialDiscriminatorProvider.Twilio => "twilio",
                UpdateAssistantDTOCredentialDiscriminatorProvider.Vonage => "vonage",
                UpdateAssistantDTOCredentialDiscriminatorProvider.Webhook => "webhook",
                UpdateAssistantDTOCredentialDiscriminatorProvider.Wellsaid => "wellsaid",
                UpdateAssistantDTOCredentialDiscriminatorProvider.Xai => "xai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssistantDTOCredentialDiscriminatorProvider? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => UpdateAssistantDTOCredentialDiscriminatorProvider.Anthropic,
                "anthropic-bedrock" => UpdateAssistantDTOCredentialDiscriminatorProvider.AnthropicBedrock,
                "anyscale" => UpdateAssistantDTOCredentialDiscriminatorProvider.Anyscale,
                "assembly-ai" => UpdateAssistantDTOCredentialDiscriminatorProvider.AssemblyAi,
                "azure" => UpdateAssistantDTOCredentialDiscriminatorProvider.Azure,
                "azure-openai" => UpdateAssistantDTOCredentialDiscriminatorProvider.AzureOpenai,
                "byo-sip-trunk" => UpdateAssistantDTOCredentialDiscriminatorProvider.ByoSipTrunk,
                "cartesia" => UpdateAssistantDTOCredentialDiscriminatorProvider.Cartesia,
                "cerebras" => UpdateAssistantDTOCredentialDiscriminatorProvider.Cerebras,
                "cloudflare" => UpdateAssistantDTOCredentialDiscriminatorProvider.Cloudflare,
                "custom-credential" => UpdateAssistantDTOCredentialDiscriminatorProvider.CustomCredential,
                "custom-llm" => UpdateAssistantDTOCredentialDiscriminatorProvider.CustomLlm,
                "deep-seek" => UpdateAssistantDTOCredentialDiscriminatorProvider.DeepSeek,
                "deepgram" => UpdateAssistantDTOCredentialDiscriminatorProvider.Deepgram,
                "deepinfra" => UpdateAssistantDTOCredentialDiscriminatorProvider.Deepinfra,
                "elevenlabs" => UpdateAssistantDTOCredentialDiscriminatorProvider.Elevenlabs,
                "email" => UpdateAssistantDTOCredentialDiscriminatorProvider.Email,
                "gcp" => UpdateAssistantDTOCredentialDiscriminatorProvider.Gcp,
                "ghl.oauth2-authorization" => UpdateAssistantDTOCredentialDiscriminatorProvider.GhlOauth2Authorization,
                "gladia" => UpdateAssistantDTOCredentialDiscriminatorProvider.Gladia,
                "gohighlevel" => UpdateAssistantDTOCredentialDiscriminatorProvider.Gohighlevel,
                "google" => UpdateAssistantDTOCredentialDiscriminatorProvider.Google,
                "google.calendar.oauth2-authorization" => UpdateAssistantDTOCredentialDiscriminatorProvider.GoogleCalendarOauth2Authorization,
                "google.calendar.oauth2-client" => UpdateAssistantDTOCredentialDiscriminatorProvider.GoogleCalendarOauth2Client,
                "google.sheets.oauth2-authorization" => UpdateAssistantDTOCredentialDiscriminatorProvider.GoogleSheetsOauth2Authorization,
                "groq" => UpdateAssistantDTOCredentialDiscriminatorProvider.Groq,
                "hume" => UpdateAssistantDTOCredentialDiscriminatorProvider.Hume,
                "inflection-ai" => UpdateAssistantDTOCredentialDiscriminatorProvider.InflectionAi,
                "inworld" => UpdateAssistantDTOCredentialDiscriminatorProvider.Inworld,
                "langfuse" => UpdateAssistantDTOCredentialDiscriminatorProvider.Langfuse,
                "lmnt" => UpdateAssistantDTOCredentialDiscriminatorProvider.Lmnt,
                "make" => UpdateAssistantDTOCredentialDiscriminatorProvider.Make,
                "minimax" => UpdateAssistantDTOCredentialDiscriminatorProvider.Minimax,
                "mistral" => UpdateAssistantDTOCredentialDiscriminatorProvider.Mistral,
                "neuphonic" => UpdateAssistantDTOCredentialDiscriminatorProvider.Neuphonic,
                "openai" => UpdateAssistantDTOCredentialDiscriminatorProvider.Openai,
                "openrouter" => UpdateAssistantDTOCredentialDiscriminatorProvider.Openrouter,
                "perplexity-ai" => UpdateAssistantDTOCredentialDiscriminatorProvider.PerplexityAi,
                "playht" => UpdateAssistantDTOCredentialDiscriminatorProvider.Playht,
                "rime-ai" => UpdateAssistantDTOCredentialDiscriminatorProvider.RimeAi,
                "runpod" => UpdateAssistantDTOCredentialDiscriminatorProvider.Runpod,
                "s3" => UpdateAssistantDTOCredentialDiscriminatorProvider.S3,
                "slack-webhook" => UpdateAssistantDTOCredentialDiscriminatorProvider.SlackWebhook,
                "slack.oauth2-authorization" => UpdateAssistantDTOCredentialDiscriminatorProvider.SlackOauth2Authorization,
                "smallest-ai" => UpdateAssistantDTOCredentialDiscriminatorProvider.SmallestAi,
                "soniox" => UpdateAssistantDTOCredentialDiscriminatorProvider.Soniox,
                "speechmatics" => UpdateAssistantDTOCredentialDiscriminatorProvider.Speechmatics,
                "supabase" => UpdateAssistantDTOCredentialDiscriminatorProvider.Supabase,
                "tavus" => UpdateAssistantDTOCredentialDiscriminatorProvider.Tavus,
                "together-ai" => UpdateAssistantDTOCredentialDiscriminatorProvider.TogetherAi,
                "trieve" => UpdateAssistantDTOCredentialDiscriminatorProvider.Trieve,
                "twilio" => UpdateAssistantDTOCredentialDiscriminatorProvider.Twilio,
                "vonage" => UpdateAssistantDTOCredentialDiscriminatorProvider.Vonage,
                "webhook" => UpdateAssistantDTOCredentialDiscriminatorProvider.Webhook,
                "wellsaid" => UpdateAssistantDTOCredentialDiscriminatorProvider.Wellsaid,
                "xai" => UpdateAssistantDTOCredentialDiscriminatorProvider.Xai,
                _ => null,
            };
        }
    }
}