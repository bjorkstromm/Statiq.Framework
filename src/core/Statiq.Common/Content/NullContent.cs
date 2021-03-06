﻿using System;
using System.IO;
using System.Threading.Tasks;

namespace Statiq.Common
{
    /// <summary>
    /// A special <see cref="IContentProvider"/> that you can use to indicate
    /// that a null content provider should be used instead of the existing
    /// content provider when cloning documents (because otherwise if <c>null</c>
    /// is passed in as the content provider the one from the existing document
    /// will be used in the cloned document).
    /// </summary>
    public sealed class NullContent : IContentProvider
    {
        public static readonly NullContent Provider = new NullContent();

        /// <summary>
        /// Use the singleton <see cref="Provider"/> field to get an instance.
        /// </summary>
        private NullContent()
        {
        }

        public Stream GetStream() => throw new NotSupportedException();
    }
}
