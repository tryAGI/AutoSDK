//HintName: JsonConverters.AssistantStreamEvent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class AssistantStreamEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.AssistantStreamEvent>
    {
        /// <inheritdoc />
        public override global::G.AssistantStreamEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AssistantStreamEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.ErrorEvent? error = default;
            if (discriminator?.Event == global::G.AssistantStreamEventDiscriminatorEvent.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ErrorEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ErrorEvent)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.DoneEvent? done = default;
            if (discriminator?.Event == global::G.AssistantStreamEventDiscriminatorEvent.Done)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.DoneEvent)}");
                done = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.AssistantStreamEventVariant3? threadCreated = default;
            if (discriminator?.Event == global::G.AssistantStreamEventDiscriminatorEvent.ThreadCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AssistantStreamEventVariant3)}");
                threadCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.AssistantStreamEventVariant4? threadRunCreated = default;
            if (discriminator?.Event == global::G.AssistantStreamEventDiscriminatorEvent.ThreadRunCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AssistantStreamEventVariant4)}");
                threadRunCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.AssistantStreamEventVariant5? threadRunQueued = default;
            if (discriminator?.Event == global::G.AssistantStreamEventDiscriminatorEvent.ThreadRunQueued)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AssistantStreamEventVariant5)}");
                threadRunQueued = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.AssistantStreamEventVariant6? threadRunInProgress = default;
            if (discriminator?.Event == global::G.AssistantStreamEventDiscriminatorEvent.ThreadRunInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AssistantStreamEventVariant6)}");
                threadRunInProgress = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.AssistantStreamEventVariant7? threadRunRequiresAction = default;
            if (discriminator?.Event == global::G.AssistantStreamEventDiscriminatorEvent.ThreadRunRequiresAction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant7> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AssistantStreamEventVariant7)}");
                threadRunRequiresAction = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.AssistantStreamEventVariant8? threadRunCompleted = default;
            if (discriminator?.Event == global::G.AssistantStreamEventDiscriminatorEvent.ThreadRunCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant8> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AssistantStreamEventVariant8)}");
                threadRunCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.AssistantStreamEventVariant9? threadRunIncomplete = default;
            if (discriminator?.Event == global::G.AssistantStreamEventDiscriminatorEvent.ThreadRunIncomplete)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant9> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AssistantStreamEventVariant9)}");
                threadRunIncomplete = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.AssistantStreamEventVariant10? threadRunFailed = default;
            if (discriminator?.Event == global::G.AssistantStreamEventDiscriminatorEvent.ThreadRunFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant10> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AssistantStreamEventVariant10)}");
                threadRunFailed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.AssistantStreamEventVariant11? threadRunCancelling = default;
            if (discriminator?.Event == global::G.AssistantStreamEventDiscriminatorEvent.ThreadRunCancelling)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant11> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AssistantStreamEventVariant11)}");
                threadRunCancelling = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.AssistantStreamEventVariant12? threadRunCancelled = default;
            if (discriminator?.Event == global::G.AssistantStreamEventDiscriminatorEvent.ThreadRunCancelled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant12> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AssistantStreamEventVariant12)}");
                threadRunCancelled = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.AssistantStreamEventVariant13? threadRunExpired = default;
            if (discriminator?.Event == global::G.AssistantStreamEventDiscriminatorEvent.ThreadRunExpired)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant13> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AssistantStreamEventVariant13)}");
                threadRunExpired = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.AssistantStreamEventVariant14? threadRunStepCreated = default;
            if (discriminator?.Event == global::G.AssistantStreamEventDiscriminatorEvent.ThreadRunStepCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant14> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AssistantStreamEventVariant14)}");
                threadRunStepCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.AssistantStreamEventVariant15? threadRunStepInProgress = default;
            if (discriminator?.Event == global::G.AssistantStreamEventDiscriminatorEvent.ThreadRunStepInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant15> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AssistantStreamEventVariant15)}");
                threadRunStepInProgress = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.AssistantStreamEventVariant16? threadRunStepDelta = default;
            if (discriminator?.Event == global::G.AssistantStreamEventDiscriminatorEvent.ThreadRunStepDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant16> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AssistantStreamEventVariant16)}");
                threadRunStepDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.AssistantStreamEventVariant17? threadRunStepCompleted = default;
            if (discriminator?.Event == global::G.AssistantStreamEventDiscriminatorEvent.ThreadRunStepCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant17> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AssistantStreamEventVariant17)}");
                threadRunStepCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.AssistantStreamEventVariant18? threadRunStepFailed = default;
            if (discriminator?.Event == global::G.AssistantStreamEventDiscriminatorEvent.ThreadRunStepFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant18), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant18> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AssistantStreamEventVariant18)}");
                threadRunStepFailed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.AssistantStreamEventVariant19? threadRunStepCancelled = default;
            if (discriminator?.Event == global::G.AssistantStreamEventDiscriminatorEvent.ThreadRunStepCancelled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant19), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant19> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AssistantStreamEventVariant19)}");
                threadRunStepCancelled = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.AssistantStreamEventVariant20? threadRunStepExpired = default;
            if (discriminator?.Event == global::G.AssistantStreamEventDiscriminatorEvent.ThreadRunStepExpired)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant20), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant20> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AssistantStreamEventVariant20)}");
                threadRunStepExpired = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.AssistantStreamEventVariant21? threadMessageCreated = default;
            if (discriminator?.Event == global::G.AssistantStreamEventDiscriminatorEvent.ThreadMessageCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant21), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant21> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AssistantStreamEventVariant21)}");
                threadMessageCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.AssistantStreamEventVariant22? threadMessageInProgress = default;
            if (discriminator?.Event == global::G.AssistantStreamEventDiscriminatorEvent.ThreadMessageInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant22), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant22> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AssistantStreamEventVariant22)}");
                threadMessageInProgress = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.AssistantStreamEventVariant23? threadMessageDelta = default;
            if (discriminator?.Event == global::G.AssistantStreamEventDiscriminatorEvent.ThreadMessageDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant23), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant23> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AssistantStreamEventVariant23)}");
                threadMessageDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.AssistantStreamEventVariant24? threadMessageCompleted = default;
            if (discriminator?.Event == global::G.AssistantStreamEventDiscriminatorEvent.ThreadMessageCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant24), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant24> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AssistantStreamEventVariant24)}");
                threadMessageCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.AssistantStreamEventVariant25? threadMessageIncomplete = default;
            if (discriminator?.Event == global::G.AssistantStreamEventDiscriminatorEvent.ThreadMessageIncomplete)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant25), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant25> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AssistantStreamEventVariant25)}");
                threadMessageIncomplete = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.AssistantStreamEvent(
                discriminator?.Event,
                error,
                done,
                threadCreated,
                threadRunCreated,
                threadRunQueued,
                threadRunInProgress,
                threadRunRequiresAction,
                threadRunCompleted,
                threadRunIncomplete,
                threadRunFailed,
                threadRunCancelling,
                threadRunCancelled,
                threadRunExpired,
                threadRunStepCreated,
                threadRunStepInProgress,
                threadRunStepDelta,
                threadRunStepCompleted,
                threadRunStepFailed,
                threadRunStepCancelled,
                threadRunStepExpired,
                threadMessageCreated,
                threadMessageInProgress,
                threadMessageDelta,
                threadMessageCompleted,
                threadMessageIncomplete
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AssistantStreamEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ErrorEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ErrorEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error, typeInfo);
            }
            else if (value.IsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Done, typeInfo);
            }
            else if (value.IsThreadCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AssistantStreamEventVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadCreated, typeInfo);
            }
            else if (value.IsThreadRunCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AssistantStreamEventVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadRunCreated, typeInfo);
            }
            else if (value.IsThreadRunQueued)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AssistantStreamEventVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadRunQueued, typeInfo);
            }
            else if (value.IsThreadRunInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant6?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AssistantStreamEventVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadRunInProgress, typeInfo);
            }
            else if (value.IsThreadRunRequiresAction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant7?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AssistantStreamEventVariant7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadRunRequiresAction, typeInfo);
            }
            else if (value.IsThreadRunCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant8?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AssistantStreamEventVariant8).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadRunCompleted, typeInfo);
            }
            else if (value.IsThreadRunIncomplete)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant9?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AssistantStreamEventVariant9).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadRunIncomplete, typeInfo);
            }
            else if (value.IsThreadRunFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant10?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AssistantStreamEventVariant10).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadRunFailed, typeInfo);
            }
            else if (value.IsThreadRunCancelling)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant11?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AssistantStreamEventVariant11).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadRunCancelling, typeInfo);
            }
            else if (value.IsThreadRunCancelled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant12?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AssistantStreamEventVariant12).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadRunCancelled, typeInfo);
            }
            else if (value.IsThreadRunExpired)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant13?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AssistantStreamEventVariant13).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadRunExpired, typeInfo);
            }
            else if (value.IsThreadRunStepCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant14?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AssistantStreamEventVariant14).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadRunStepCreated, typeInfo);
            }
            else if (value.IsThreadRunStepInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant15?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AssistantStreamEventVariant15).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadRunStepInProgress, typeInfo);
            }
            else if (value.IsThreadRunStepDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant16?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AssistantStreamEventVariant16).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadRunStepDelta, typeInfo);
            }
            else if (value.IsThreadRunStepCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant17?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AssistantStreamEventVariant17).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadRunStepCompleted, typeInfo);
            }
            else if (value.IsThreadRunStepFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant18), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant18?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AssistantStreamEventVariant18).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadRunStepFailed, typeInfo);
            }
            else if (value.IsThreadRunStepCancelled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant19), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant19?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AssistantStreamEventVariant19).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadRunStepCancelled, typeInfo);
            }
            else if (value.IsThreadRunStepExpired)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant20), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant20?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AssistantStreamEventVariant20).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadRunStepExpired, typeInfo);
            }
            else if (value.IsThreadMessageCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant21), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant21?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AssistantStreamEventVariant21).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadMessageCreated, typeInfo);
            }
            else if (value.IsThreadMessageInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant22), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant22?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AssistantStreamEventVariant22).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadMessageInProgress, typeInfo);
            }
            else if (value.IsThreadMessageDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant23), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant23?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AssistantStreamEventVariant23).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadMessageDelta, typeInfo);
            }
            else if (value.IsThreadMessageCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant24), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant24?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AssistantStreamEventVariant24).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadMessageCompleted, typeInfo);
            }
            else if (value.IsThreadMessageIncomplete)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantStreamEventVariant25), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantStreamEventVariant25?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AssistantStreamEventVariant25).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadMessageIncomplete, typeInfo);
            }
        }
    }
}