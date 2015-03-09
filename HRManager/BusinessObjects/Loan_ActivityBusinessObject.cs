using System;
using System.Data;
using IS91.Services.DataBlock;
using System.Collections;
using HRManager.DTO;

namespace HRManager.BusinessObjects
{
public partial class Loan_ActivityBusinessObject
{ 

       private Loan_Activity mapped = new Loan_Activity();
       private PersistentObject persistent = null; 


      #region Constructors
      public Loan_ActivityBusinessObject(DatabaseServer database, string connectionString) 
      {
           persistent = new PersistentObject(database, connectionString, mapped);
      }

      
      public Loan_ActivityBusinessObject(Session session)
      {
           persistent = new PersistentObject(session, mapped);
      }

      public Loan_ActivityBusinessObject()
      {
           persistent = new PersistentObject(mapped);
      }
		#endregion


       #region generated implementation
   public DataTable GetDataTable()
	 {
        return persistent.GetDataTable();
	 }


   public DataTable GetDataTable(QueryCriteria qc)
	 {
        return persistent.GetDataTable(qc);
	 }


   public DataTable GetDataTable(params DatabaseField[] fields)
	 {
        return persistent.GetDataTable(fields);
	 }


   public Loan_Activity[] GetLoan_Activity()
	 {
        	 return (Loan_Activity[])persistent.GetTableMetadata();
	 }


   public Loan_Activity GetLoan_Activity(object primaryKeyValue)
   {
      	return(Loan_Activity)persistent.GetTableMetadata(primaryKeyValue);
   }


   public Loan_Activity[] GetLoan_Activity(QueryCriteria qc)
   {
      	return(Loan_Activity[])persistent.GetTableMetadata(qc);
   }


   public  Array GetLoan_Activity(string relatedTableName, Type classType, object foreignKeyValue)
   {
     		return persistent.GetTableMetadata(relatedTableName, classType, foreignKeyValue);
	 }


   public ArrayList GetFieldList(QueryCriteria criteria)
	 {
         return persistent.GetFieldList(criteria);
	 }


   public ArrayList GetFieldList(DatabaseField field)
	 {
        	 return persistent.GetFieldList(field);
	 }


   public object GetValue (QueryCriteria criteria)
	 {
         return persistent.GetValue(criteria);
	 }


   public bool IsUnique (DatabaseField field, object value)
	 {
        	 return persistent.IsUnique(field, value);
	 }


	public object GetMax(DatabaseField field)
	{
		return persistent.GetMax(field);
	}


	public object GetMin(DatabaseField field)
	{
		return persistent.GetMin(field);
	}


	public object GetCount()
	{
		return persistent.GetCount();
	}


	public int Create(Loan_Activity mappedObject)
	{
		return persistent.Create(mappedObject);
	}


	public int Update(Loan_Activity mappedObject)
	{
		return persistent.Update(mappedObject);
	}


	public int Update(QueryCriteria criteria)
	{
		return persistent.Update(criteria);
	}


	public int Delete(Loan_Activity mappedObject)
	{
		return persistent.Delete(mappedObject);
	}


	public int Delete(QueryCriteria criteria)
	{
		return persistent.Delete(criteria);
	}


	public int Delete(object id)
	{
		return persistent.Delete(id);
	}


       #endregion
 
   }
}
