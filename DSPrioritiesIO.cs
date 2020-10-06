/*
 * Created by SharpDevelop.
 * User: Benoit Le Guern
 * Date: 12/04/2007
 * Time: 23:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Data;
using System.Text;
using System.IO;

namespace DS_Priorities
{
	/// <summary>
	/// Description of DSPrioritiesIO.
	/// </summary>
	public class DSPrioritiesIO
	{
		public DSPrioritiesIO()
		{
			
		}
		
		public static bool LoadFile(string fileName, ref DataTable table)
        {
            try
            {
                StreamReader sr = new StreamReader(fileName, Encoding.GetEncoding(1252));

                string line;
                int lineCount = 1;

                while ((line = sr.ReadLine()) != null)
                {
                    try
                    {
                        DataRow row = table.NewRow();
                        int lineRow = 0;

                        for (int j = 0; j < table.Columns.Count; j++)
                        {
                            string value = line.Substring(lineRow, table.Columns[j].MaxLength).Trim();

                            if (table.Columns[j].Caption == "Number")
                            {
                                row[j] = Convert.ToInt32(value).ToString();
                            }
                            else if (table.Columns[j].Caption == "Decimal")
                            {
                                row[j] = Convert.ToDecimal(value).ToString();
                            }
                            else
                            {
                                row[j] = value;
                            }
                        

                            lineRow += table.Columns[j].MaxLength;
                        }

                        table.Rows.Add(row);
                    }
                    catch (Exception)
                    {
                        
                    }

                    lineCount++;
                }

                sr.Close();

                return true;
            }
            catch (Exception)
            {
               	
            }
            
            return false;
        }
		
		public static bool LoadTabFile(string fileName, ref DataTable table)
        {
            try
            {
                StreamReader sr = new StreamReader(fileName, Encoding.GetEncoding(1252));

                string line;
                int lineCount = 1;

                while ((line = sr.ReadLine()) != null)
                {
                    try
                    {
                        DataRow row = table.NewRow();
                        
                        string [] value = line.Split('	');

                        if (value.Length >= table.Columns.Count)
                        {
	                        for (int j = 0; j < table.Columns.Count; j++)
	                        {
	                        	value[j] = value[j].Trim();
	
	                            if (table.Columns[j].Caption == "Number")
	                            {
	                            	row[j] = Convert.ToInt32(value[j]).ToString();
	                            }
	                            else if (table.Columns[j].Caption == "Decimal")
	                            {
	                                row[j] = Convert.ToDecimal(value[j]).ToString();
	                            }
	                            else
	                            {
	                                row[j] = value[j];
	                            }
	                        }
                        }

                        table.Rows.Add(row);
                    }
                    catch (Exception)
                    {
                        
                    }

                    lineCount++;
                }

                sr.Close();

                return true;
            }
            catch (Exception)
            {
               	
            }
            
            return false;
        }
		
		public static bool WriteFile(string fileName, DataTable table)
        {
            try
            {
                StreamWriter sw = new StreamWriter(fileName, false, Encoding.GetEncoding(1252));

                foreach (DataRow row in table.Rows)
                {
                    string line = "";

                    for (int i = 0; i < table.Columns.Count; i++)
                    {
                        string value = "";
                        
                        try
                        {
                            if (table.Columns[i].Caption == "Number")
                            {
                                int number = Convert.ToInt32(row[i].ToString());
                                value = number.ToString().PadLeft(table.Columns[i].MaxLength, ' ');

                            }
                            else if (table.Columns[i].Caption == "Decimal")
                            {
                                decimal number = Convert.ToDecimal(row[i].ToString());
                                value = number.ToString("F").PadLeft(table.Columns[i].MaxLength, ' ');
                            }
                            else
                            {
                                value = row[i].ToString().PadRight(table.Columns[i].MaxLength, ' ');
                            }
                        }
                        catch (FormatException)
                        {
                            value = row[i].ToString().PadRight(table.Columns[i].MaxLength, ' ');
                        }
                        catch (OverflowException)
                        {
                            value = " ".PadRight(table.Columns[i].MaxLength, ' ');
                        }

                        line += value;
                    }

                    sw.WriteLine(line);
                }

                sw.Close();

                return true;
            }
            catch (Exception)
            {
                
            }
            
            return false;
        }
	}
}
