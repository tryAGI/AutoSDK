//HintName: G.JsonConverters.ClusterOperations.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ClusterOperationsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ClusterOperations>
    {
        /// <inheritdoc />
        public override global::G.ClusterOperations Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("move_shard")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("replicate_shard")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("abort_transfer")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("drop_replica")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("create_sharding_key")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("drop_sharding_key")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("restart_transfer")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("start_resharding")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("abort_resharding")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("replicate_points")) __score9++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }
            if (__score9 > __bestScore) { __bestScore = __score9; __bestIndex = 9; }

            global::G.MoveShardOperation? moveShardOperation = default;
            global::G.ReplicateShardOperation? replicateShardOperation = default;
            global::G.AbortTransferOperation? abortTransferOperation = default;
            global::G.DropReplicaOperation? dropReplicaOperation = default;
            global::G.CreateShardingKeyOperation? createShardingKeyOperation = default;
            global::G.DropShardingKeyOperation? dropShardingKeyOperation = default;
            global::G.RestartTransferOperation? restartTransferOperation = default;
            global::G.StartReshardingOperation? startReshardingOperation = default;
            global::G.AbortReshardingOperation? abortReshardingOperation = default;
            global::G.ReplicatePointsOperation? replicatePointsOperation = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MoveShardOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MoveShardOperation> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MoveShardOperation).Name}");
                        moveShardOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReplicateShardOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReplicateShardOperation> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReplicateShardOperation).Name}");
                        replicateShardOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AbortTransferOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AbortTransferOperation> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AbortTransferOperation).Name}");
                        abortTransferOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DropReplicaOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DropReplicaOperation> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DropReplicaOperation).Name}");
                        dropReplicaOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateShardingKeyOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateShardingKeyOperation> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateShardingKeyOperation).Name}");
                        createShardingKeyOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DropShardingKeyOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DropShardingKeyOperation> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DropShardingKeyOperation).Name}");
                        dropShardingKeyOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RestartTransferOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RestartTransferOperation> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RestartTransferOperation).Name}");
                        restartTransferOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 7)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StartReshardingOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StartReshardingOperation> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StartReshardingOperation).Name}");
                        startReshardingOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 8)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AbortReshardingOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AbortReshardingOperation> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AbortReshardingOperation).Name}");
                        abortReshardingOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 9)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReplicatePointsOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReplicatePointsOperation> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReplicatePointsOperation).Name}");
                        replicatePointsOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (moveShardOperation == null && replicateShardOperation == null && abortTransferOperation == null && dropReplicaOperation == null && createShardingKeyOperation == null && dropShardingKeyOperation == null && restartTransferOperation == null && startReshardingOperation == null && abortReshardingOperation == null && replicatePointsOperation == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MoveShardOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MoveShardOperation> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MoveShardOperation).Name}");
                    moveShardOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReplicateShardOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReplicateShardOperation> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReplicateShardOperation).Name}");
                    replicateShardOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AbortTransferOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AbortTransferOperation> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AbortTransferOperation).Name}");
                    abortTransferOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DropReplicaOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DropReplicaOperation> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DropReplicaOperation).Name}");
                    dropReplicaOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateShardingKeyOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateShardingKeyOperation> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateShardingKeyOperation).Name}");
                    createShardingKeyOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DropShardingKeyOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DropShardingKeyOperation> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DropShardingKeyOperation).Name}");
                    dropShardingKeyOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RestartTransferOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RestartTransferOperation> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RestartTransferOperation).Name}");
                    restartTransferOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StartReshardingOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StartReshardingOperation> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StartReshardingOperation).Name}");
                    startReshardingOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AbortReshardingOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AbortReshardingOperation> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AbortReshardingOperation).Name}");
                    abortReshardingOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReplicatePointsOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReplicatePointsOperation> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReplicatePointsOperation).Name}");
                    replicatePointsOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ClusterOperations(
                moveShardOperation,

                replicateShardOperation,

                abortTransferOperation,

                dropReplicaOperation,

                createShardingKeyOperation,

                dropShardingKeyOperation,

                restartTransferOperation,

                startReshardingOperation,

                abortReshardingOperation,

                replicatePointsOperation
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ClusterOperations value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMoveShardOperation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MoveShardOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MoveShardOperation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MoveShardOperation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MoveShardOperation, typeInfo);
            }
            else if (value.IsReplicateShardOperation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReplicateShardOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReplicateShardOperation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReplicateShardOperation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReplicateShardOperation, typeInfo);
            }
            else if (value.IsAbortTransferOperation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AbortTransferOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AbortTransferOperation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AbortTransferOperation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AbortTransferOperation, typeInfo);
            }
            else if (value.IsDropReplicaOperation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DropReplicaOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DropReplicaOperation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DropReplicaOperation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DropReplicaOperation, typeInfo);
            }
            else if (value.IsCreateShardingKeyOperation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateShardingKeyOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateShardingKeyOperation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateShardingKeyOperation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateShardingKeyOperation, typeInfo);
            }
            else if (value.IsDropShardingKeyOperation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DropShardingKeyOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DropShardingKeyOperation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DropShardingKeyOperation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DropShardingKeyOperation, typeInfo);
            }
            else if (value.IsRestartTransferOperation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RestartTransferOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RestartTransferOperation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RestartTransferOperation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RestartTransferOperation, typeInfo);
            }
            else if (value.IsStartReshardingOperation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StartReshardingOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StartReshardingOperation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StartReshardingOperation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StartReshardingOperation, typeInfo);
            }
            else if (value.IsAbortReshardingOperation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AbortReshardingOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AbortReshardingOperation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AbortReshardingOperation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AbortReshardingOperation, typeInfo);
            }
            else if (value.IsReplicatePointsOperation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReplicatePointsOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReplicatePointsOperation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReplicatePointsOperation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReplicatePointsOperation, typeInfo);
            }
        }
    }
}