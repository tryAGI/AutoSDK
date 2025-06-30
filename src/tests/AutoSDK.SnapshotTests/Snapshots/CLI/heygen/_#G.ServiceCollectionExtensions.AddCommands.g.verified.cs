//HintName: G.ServiceCollectionExtensions.AddCommands.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Provides extension methods for adding command services to the dependency injection container.
    /// </summary>
    internal static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Registers all command services required by the application into the dependency injection container.
        /// </summary>
        /// <param name="services">The <see cref="global::Microsoft.Extensions.DependencyInjection.IServiceCollection"/> to which the services will be added.</param>
        /// <returns>The updated <see cref="global::Microsoft.Extensions.DependencyInjection.IServiceCollection"/> instance.</returns>
        public static global::Microsoft.Extensions.DependencyInjection.IServiceCollection AddCommands(
            this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services)
        {
            // Register individual command services as singletons
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                V1VoiceListCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                V1AvatarListCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                V2VoicesCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                V2AvatarsCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                V1VideoListCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                V2VideoGenerateCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                V1VideoDeleteCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                V2TemplatesCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                V2TemplateIdCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                V2TemplateGenerateCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                V2VideoTranslateTargetLanguagesCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                V2VideoTranslateCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                V2VideoTranslateIdStatusCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                StreamingNewCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                StreamingStartCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                StreamingListCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                StreamingIceCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                StreamingTaskCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                StreamingStopCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                StreamingInterruptCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                StreamingCreateTokenCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                StreamingAvatarListCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                V1WebhookWebhookListCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                V1WebhookEndpointAddCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                V1WebhookEndpointDeleteCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                V1WebhookEndpointListCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                V1TalkingPhotoListCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                V1TalkingPhotoUploadCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                V2TalkingPhotoIdDeleteCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                PersonalizedVideoAddContactCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                PersonalizedVideoAudienceDetailCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                PersonalizedVideoProjectDetailCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                V2UserRemainingQuotaCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                V1AssetUploadCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                V1VideoStatusGetCommand>(services);

            // Register grouped command services as singletons
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                ListGroupCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                CreateVideoAPIGroupCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                TemplateAPIGroupCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                VideoTranslateAPIGroupCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                StreamingAPIGroupCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                WebhookGroupCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                TalkingPhotoGroupCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                PersonalizedVideoGroupCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                UserGroupCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                AssetGroupCommand>(services);

            // Register the main command service as a singleton
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                MainCommand>(services);

            return services;
        }
    }
}