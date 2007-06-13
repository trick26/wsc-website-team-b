using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;

namespace BLL
{
    /// <summary>
    /// Summary description for CatalogComponent
    /// </summary>
    public class CatalogComponent
    {
        public CatalogComponent()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Item> GetItems()
        {
            List<Item> items = new List<Item>();
            DataSet ds = new DataSet();
            DataSetTableAdapters.catalogTableAdapter adapter = new DataSetTableAdapters.catalogTableAdapter();
            adapter.Fill(ds.catalog);
            DataSet.catalogDataTable table = adapter.GetCatalogData();

            // load all items into the list
            foreach (DataSet.catalogRow row in table.Rows)
            {
                // create memory for new item & fill in properties
                Item it = new Item();
                it.ID = row.catalogId;
                it.Description = row.description;
                it.Notes = row.notes;
                it.Photo = row.photo;
                it.ThumbPhoto = row.thumbPhoto;
                it.Price = row.price;

                // add this item to the list
                items.Add(it);
            }
            // returns the list w/ 0 or more items
            return items;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>An Item if found; null if not found</returns>
        public Item GetItemById(int id)
        {
            DataSet ds = new DataSet();
            DataSetTableAdapters.catalogTableAdapter adapter = new DataSetTableAdapters.catalogTableAdapter();
            adapter.Fill(ds.catalog);
            Item it = new Item();

            // find the item
            DataSet.catalogDataTable table = adapter.GetItemById(id);

            // if an item was found, then fill in the details 
            if (table.Rows.Count > 0)
            {
                // use the 1st row's data
                DataSet.catalogRow row = (DataSet.catalogRow)table.Rows[0];
                it.ID = row.catalogId;
                it.Description = row.description;
                it.Notes = row.notes;
                it.Photo = row.photo;
                it.ThumbPhoto = row.thumbPhoto;
                it.Price = row.price;
                return it;
            }
            else
            {
                return null;
            }

        }

        public int UpdateItem(Item it)
        {
            return UpdateItem(it.ID, it.Description, it.Notes, it.ThumbPhoto, it.Photo, it.Price);
        }

        public int UpdateItem(int id, String description, String notes, String photo, String thumbPhoto, double price)
        {
            DataSet ds = new DataSet();
            DataSetTableAdapters.catalogTableAdapter adapter = new DataSetTableAdapters.catalogTableAdapter();

            return adapter.Update(description, notes, photo, thumbPhoto, price, id);
        }

        public int InsertItem(Item it)
        {
            return InsertItem(it.Description, it.Notes, it.Photo, it.ThumbPhoto, it.Price);
        }

        public int InsertItem(String description, String notes, String photo, String thumbPhoto, double price)
        {
            DataSet ds = new DataSet();
            DataSetTableAdapters.catalogTableAdapter adapter = new DataSetTableAdapters.catalogTableAdapter();

            return adapter.Insert(description, notes, photo, thumbPhoto, price);
        }

        public int DeleteItem(Item it)
        {
            return DeleteItem(it.ID);
        }

        public int DeleteItem(int catalogId)
        {
            DataSet ds = new DataSet();
            DataSetTableAdapters.catalogTableAdapter adapter = new DataSetTableAdapters.catalogTableAdapter();

            return adapter.Delete(catalogId);
        }
    }
}