﻿using System.Text;

// ReSharper disable once CheckNamespace - All extensions are within the same namespace otherwise they don't show up in intellisense
namespace Entelect.Extensions
{
    public static class StringBuilderExtensions
    {
        /// <summary>
        /// Appends the args and a new line character
        /// </summary>
        /// <param name="input">The string builder to append to.</param>
        /// <param name="value">The string with the format placeholders.</param>
        /// <param name="arg0">The parameter to use within the formatted string.</param>
        /// <returns></returns>
        public static StringBuilder AppendLineFormat(this StringBuilder input, string value, object arg0)
        {
            return input.AppendFormat(value, arg0).AppendLine();
        }

        /// <summary>
        /// Appends the args and a new line character
        /// </summary>
        /// <param name="input">The string builder to append to.</param>
        /// <param name="value">The string with the format placeholders.</param>
        /// <param name="arg0">The first parameter to use within the formatted string.</param>
        /// <param name="arg1">The second parameter to use within the formatted string.</param>
        /// <returns></returns>
        public static StringBuilder AppendLineFormat(this StringBuilder input, string value, object arg0, object arg1)
        {
            return input.AppendFormat(value, arg0, arg1).AppendLine();
        }

        /// <summary>
        /// Appends the args and a new line character
        /// </summary>
        /// <param name="input">The string builder to append to.</param>
        /// <param name="value">The string with the format placeholders.</param>
        /// <param name="arg0">The first parameter to use within the formatted string.</param>
        /// <param name="arg1">The second parameter to use within the formatted string.</param>
        /// <param name="arg2">The third parameter to use within the formatted string.</param>
        /// <returns></returns>
        public static StringBuilder AppendLineFormat(this StringBuilder input, string value, object arg0, object arg1, object arg2)
        {
            return input.AppendFormat(value, arg0, arg1, arg2).AppendLine();
        }

        /// <summary>
        /// Appends the args and a new line character
        /// </summary>
        /// <param name="input">The string builder to append to.</param>
        /// <param name="value">The string with the format placeholders.</param>
        /// <param name="args">The parameter to use within the formatted string.</param>
        /// <returns></returns>
        public static StringBuilder AppendLineFormat(this StringBuilder input, string value, params object[] args)
        {
            return input.AppendFormat(value, args).AppendLine();
        }
    }
}
