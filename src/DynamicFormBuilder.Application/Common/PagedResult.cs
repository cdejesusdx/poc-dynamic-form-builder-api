﻿namespace DynamicFormBuilder.Application.Common
{
    public class PagedResult<T>
    {
        public int TotalCount { get; set; }
        public IEnumerable<T> Items { get; set; } = Enumerable.Empty<T>();
    }
}