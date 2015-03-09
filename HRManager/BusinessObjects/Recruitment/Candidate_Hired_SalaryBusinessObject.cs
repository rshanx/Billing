using System;
using System.Data;
using IS91.Services.DataBlock;
using System.Collections;
using HRManager.DTO;

namespace HRManager.BusinessObjects
{
    public partial class Candidate_Hired_SalaryBusinessObject
    { 

        private Candidate_Hired_Salary mapped = new Candidate_Hired_Salary();
        private PersistentObject persistent = null; 

        #region Constructors
      public Candidate_Hired_SalaryBusinessObject(DatabaseServer database, string connectionString) 
      {
           persistent = new PersistentObject(database, connectionString, mapped);
      }

      
      public Candidate_Hired_SalaryBusinessObject(Session session)
      {
           persistent = new PersistentObject(session, mapped);
      }

      public Candidate_Hired_SalaryBusinessObject()
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


   public Candidate_Hired_Salary[] GetCandidate_Hired_Salary()
	 {
        	 return (Candidate_Hired_Salary[])persistent.GetTableMetadata();
	 }


   public Candidate_Hired_Salary GetCandidate_Hired_Salary(object primaryKeyValue)
   {
      	return(Candidate_Hired_Salary)persistent.GetTableMetadata(primaryKeyValue);
   }


   public Candidate_Hired_Salary[] GetCandidate_Hired_Salary(QueryCriteria qc)
   {
      	return(Candidate_Hired_Salary[])persistent.GetTableMetadata(qc);
   }


   public  Array GetCandidate_Hired_Salary(string relatedTableName, Type classType, object foreignKeyValue)
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


	public int Create(Candidate_Hired_Salary mappedObject)
	{
		return persistent.Create(mappedObject);
	}


	public int Update(Candidate_Hired_Salary mappedObject)
	{
		return persistent.Update(mappedObject);
	}


	public int Update(QueryCriteria criteria)
	{
		return persistent.Update(criteria);
	}


	public int Delete(Candidate_Hired_Salary mappedObject)
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
