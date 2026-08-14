using System;
using System.Collections.Generic;
using AutoSDK.Helpers;
using AutoSDK.Models;
using Microsoft.OpenApi;

namespace AutoSDK.Generation;

/// <summary>
/// Infers, for every generated C# type, whether it is reachable from request payloads,
/// from response payloads, or from both. The result drives the
/// <c>JsonSourceGenerationMode</c> emitted on each <c>[JsonSerializable]</c> registration.
/// </summary>
public static class JsonSerializationDirectionAnalyzer
{
    /// <summary>
    /// Walks the operation graph and returns a map from
    /// <see cref="TypeData.CSharpTypeWithoutNullability"/> to the directions it is used in.
    /// Types that are not reachable from any operation are absent from the map and must be
    /// treated as ambiguous by callers.
    /// </summary>
    public static Dictionary<string, JsonSerializationDirection> Analyze(
        IReadOnlyList<SchemaContext> schemas)
    {
        schemas = schemas ?? throw new ArgumentNullException(nameof(schemas));

        var directions = new Dictionary<string, JsonSerializationDirection>(StringComparer.Ordinal);

        Mark(schemas, JsonSerializationDirection.Request, directions);
        Mark(schemas, JsonSerializationDirection.Response, directions);

        return directions;
    }

    private static void Mark(
        IReadOnlyList<SchemaContext> schemas,
        JsonSerializationDirection direction,
        Dictionary<string, JsonSerializationDirection> directions)
    {
        // A single visited set is shared by every root of the same direction: once a node has
        // been marked with that direction, re-entering it from another root cannot add anything.
        var visited = new HashSet<SchemaContext>();
        var stack = new Stack<SchemaContext>();

        for (var i = 0; i < schemas.Count; i++)
        {
            var schema = schemas[i];
            if (GetRootDirection(schema) != direction)
            {
                continue;
            }

            stack.Push(schema);
            Walk(stack, visited, direction, directions);
        }
    }

    private static void Walk(
        Stack<SchemaContext> stack,
        HashSet<SchemaContext> visited,
        JsonSerializationDirection direction,
        Dictionary<string, JsonSerializationDirection> directions)
    {
        while (stack.Count > 0)
        {
            var current = stack.Pop();
            if (!visited.Add(current))
            {
                continue;
            }

            AddDirection(directions, current.TypeData.CSharpTypeWithoutNullability, direction);
            foreach (var subType in current.TypeData.SubTypes)
            {
                AddDirection(
                    directions,
                    subType.Unbox<TypeData>().CSharpTypeWithoutNullability,
                    direction);
            }

            if (current.ResolvedReference is { } resolvedReference)
            {
                stack.Push(resolvedReference);
            }

            var children = current.Children;
            for (var i = 0; i < children.Count; i++)
            {
                stack.Push(children[i]);
            }

            // Derived classes are separate components that the base schema does not reference,
            // so polymorphic payloads would otherwise lose the direction of their subtypes.
            PushDiscriminatorMappings(current, stack);
        }
    }

    private static void PushDiscriminatorMappings(
        SchemaContext current,
        Stack<SchemaContext> stack)
    {
        if (current.ComponentSchemas is not { } componentSchemas ||
            current.Schema.Discriminator?.Mapping is not { Count: > 0 } mapping)
        {
            return;
        }

        foreach (var value in mapping.Values)
        {
            var referenceId = value?.Reference?.Id;
            if (referenceId is null)
            {
                continue;
            }

            if (componentSchemas.TryGetValue(referenceId, out var mapped))
            {
                stack.Push(mapped);
            }
        }
    }

    private static JsonSerializationDirection GetRootDirection(SchemaContext schema)
    {
        if (!schema.IsOperation)
        {
            return JsonSerializationDirection.None;
        }

        return schema.Hint switch
        {
            // Parameters are only ever written by the SDK, so they count as request usage.
            Hint.Request or Hint.Parameter => JsonSerializationDirection.Request,
            Hint.Response => JsonSerializationDirection.Response,
            _ => JsonSerializationDirection.None,
        };
    }

    private static void AddDirection(
        Dictionary<string, JsonSerializationDirection> directions,
        string type,
        JsonSerializationDirection direction)
    {
        if (string.IsNullOrWhiteSpace(type))
        {
            return;
        }

        directions[type] = directions.TryGetValue(type, out var existing)
            ? existing | direction
            : direction;
    }
}
