// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IWorkbookTableRequestBuilder.
    /// </summary>
    public partial interface IWorkbookTableRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IWorkbookTableRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IWorkbookTableRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Columns.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableColumnsCollectionRequestBuilder"/>.</returns>
        IWorkbookTableColumnsCollectionRequestBuilder Columns { get; }

        /// <summary>
        /// Gets the request builder for Rows.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableRowsCollectionRequestBuilder"/>.</returns>
        IWorkbookTableRowsCollectionRequestBuilder Rows { get; }

        /// <summary>
        /// Gets the request builder for Sort.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableSortRequestBuilder"/>.</returns>
        IWorkbookTableSortRequestBuilder Sort { get; }

        /// <summary>
        /// Gets the request builder for Worksheet.
        /// </summary>
        /// <returns>The <see cref="IWorkbookWorksheetRequestBuilder"/>.</returns>
        IWorkbookWorksheetRequestBuilder Worksheet { get; }
    
        /// <summary>
        /// Gets the request builder for WorkbookTableClearFilters.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableClearFiltersRequestBuilder"/>.</returns>
        IWorkbookTableClearFiltersRequestBuilder ClearFilters();

        /// <summary>
        /// Gets the request builder for WorkbookTableConvertToRange.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableConvertToRangeRequestBuilder"/>.</returns>
        IWorkbookTableConvertToRangeRequestBuilder ConvertToRange();

        /// <summary>
        /// Gets the request builder for WorkbookTableReapplyFilters.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableReapplyFiltersRequestBuilder"/>.</returns>
        IWorkbookTableReapplyFiltersRequestBuilder ReapplyFilters();

        /// <summary>
        /// Gets the request builder for WorkbookTableDataBodyRange.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableDataBodyRangeRequestBuilder"/>.</returns>
        IWorkbookTableDataBodyRangeRequestBuilder DataBodyRange();

        /// <summary>
        /// Gets the request builder for WorkbookTableHeaderRowRange.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableHeaderRowRangeRequestBuilder"/>.</returns>
        IWorkbookTableHeaderRowRangeRequestBuilder HeaderRowRange();

        /// <summary>
        /// Gets the request builder for WorkbookTableRange.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableRangeRequestBuilder"/>.</returns>
        IWorkbookTableRangeRequestBuilder Range();

        /// <summary>
        /// Gets the request builder for WorkbookTableTotalRowRange.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableTotalRowRangeRequestBuilder"/>.</returns>
        IWorkbookTableTotalRowRangeRequestBuilder TotalRowRange();
    
    }
}
