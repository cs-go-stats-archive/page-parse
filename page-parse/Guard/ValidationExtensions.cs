using System;

namespace CSGOStats.Infrastructure.PageParse.Guard
{
    // TODO: move to separate assembly
    public static class ValidationExtensions
    {
        public static T NotNull<T>(this T instance, string argumentName)
            where T : class => instance ?? throw new ArgumentNullException(argumentName);

        public static T ShouldHaveValue<T>(this T? instance, string objectName)
            where T : struct => instance ?? throw new InvalidOperationException($"{objectName} doesn't have value.");

        public static T ShouldNotBe<T>(this T instance, T unwantedValue, string objectName) => instance.Equals(unwantedValue)
            ? throw new InvalidOperationException($"Value '{instance}' of '{objectName}' is invalid in current conditions.")
            : instance;
    }
}