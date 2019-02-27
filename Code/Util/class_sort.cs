using System.Collections;
/// <summary>
/// This class is an implementation of the 'IComparer' interface.
/// </summary>
public class ListViewColumnSorter : IComparer
{
    /// <summary>
    /// Specifies the order in which to sort (i.e. 'Ascending').
    /// </summary>
    private System.Windows.Forms.SortOrder OrderOfSort;
	/// <summary>
	/// Case insensitive comparer object
	/// </summary>
	private CaseInsensitiveComparer ObjectCompare;

	/// <summary>
	/// Class constructor.  Initializes various elements
	/// </summary>
	public ListViewColumnSorter()
	{
		// Initialize the column to '0'
		SortColumn = 0;

		// Initialize the sort order to 'none'
		OrderOfSort = System.Windows.Forms.SortOrder.None;

		// Initialize the CaseInsensitiveComparer object
		ObjectCompare = new CaseInsensitiveComparer();
	}

	/// <summary>
	/// This method is inherited from the IComparer interface.  It compares the two objects passed using a case insensitive comparison.
	/// </summary>
	/// <param name="x">First object to be compared</param>
	/// <param name="y">Second object to be compared</param>
	/// <returns>The result of the comparison. "0" if equal, negative if 'x' is less than 'y' and positive if 'x' is greater than 'y'</returns>
	public int Compare(object x, object y)
	{
        try
        {
            int compareResult;
            System.Windows.Forms.ListViewItem listviewX, listviewY;

            // Cast the objects to be compared to ListViewItem objects
            listviewX = (System.Windows.Forms.ListViewItem)x;
            listviewY = (System.Windows.Forms.ListViewItem)y;

            // Compare the two items
            compareResult = ObjectCompare.Compare(listviewX.SubItems[SortColumn].Text, listviewY.SubItems[SortColumn].Text);

            // Calculate correct return value based on object comparison
            if (OrderOfSort == System.Windows.Forms.SortOrder.Ascending)
            {
                // Ascending sort is selected, return normal result of compare operation
                return compareResult;
            }
            else if (OrderOfSort == System.Windows.Forms.SortOrder.Descending)
            {
                // Descending sort is selected, return negative result of compare operation
                return -compareResult;
            }
            else
            {
                // Return '0' to indicate they are equal
                return 0;
            }
        }
        catch
        {
            return 0;
        }
	}

    /// <summary>
    /// Gets or sets the number of the column to which to apply the sorting operation (Defaults to '0').
    /// </summary>
    public int SortColumn { set; get; }

    /// <summary>
    /// Gets or sets the order of sorting to apply (for example, 'Ascending' or 'Descending').
    /// </summary>
    public System.Windows.Forms.SortOrder Order
	{
		set
		{
			OrderOfSort = value;
		}
		get
		{
			return OrderOfSort;
		}
	}

}