using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Provider;

namespace AppeveliFilePicker
{
    class WriteMultipleText
    {
        /*
         SuggestedFileName is the suggested file name to the user. The user has a choice to change the filename.
         * DataOne and DataTwo is the Label Text ex...Hardcoded Text.
         * TextOne and TextTwo stores user input data.
         * Analysis: Some applications will store an analysis or summary. ex..finance or educational applications 
         
         */
        public async void WriteTwoStringObjects(string SuggestedFileName, string DataOne, string TextOne,
            string DataTwo, string TextTwo, string Result)
        {
            FileSavePicker savePicker = new FileSavePicker();
            savePicker.SuggestedStartLocation = PickerLocationId.DocumentsLibrary;
            // Dropdown of file types the user can save the file as
            savePicker.FileTypeChoices.Add("Plain Text", new List<string>() { ".txt" });
            // Default file name if the user does not type one in or select a file to replace
            savePicker.SuggestedFileName = SuggestedFileName;
            StorageFile file = await savePicker.PickSaveFileAsync();
            if (file != null)
            {
                // Prevent updates to the remote version of the file until we finish making changes and call CompleteUpdatesAsync.
                CachedFileManager.DeferUpdates(file);
                // write to file
                await FileIO.WriteTextAsync(file, DataOne + ": " + TextOne + "\n");
                await FileIO.AppendTextAsync(file, DataTwo + ": " + TextTwo + "\n");
                await FileIO.AppendTextAsync(file, Result);
                // Let Windows know that we're finished changing the file so the other app can update the remote version of the file.
                // Completing updates may require Windows to ask for user input.
                FileUpdateStatus status = await CachedFileManager.CompleteUpdatesAsync(file);
                if (status == FileUpdateStatus.Complete)
                {
                    // Display output if file is saved
                }
                else
                {
                    // Display output if file is not saved
                }
            }
            else
            {
                // File Operation cancelled
            }

        }
        public async void WriteTwoStringObjectsWithAnalysis(string SuggestedFileName, string DataOne, string TextOne,
           string DataTwo, string TextTwo, string Result, string Analysis)
        {
            FileSavePicker savePicker = new FileSavePicker();
            savePicker.SuggestedStartLocation = PickerLocationId.DocumentsLibrary;
            // Dropdown of file types the user can save the file as
            savePicker.FileTypeChoices.Add("Plain Text", new List<string>() { ".txt" });
            // Default file name if the user does not type one in or select a file to replace
            savePicker.SuggestedFileName = SuggestedFileName;
            StorageFile file = await savePicker.PickSaveFileAsync();
            if (file != null)
            {
                // Prevent updates to the remote version of the file until we finish making changes and call CompleteUpdatesAsync.
                CachedFileManager.DeferUpdates(file);
                // write to file
                await FileIO.WriteTextAsync(file, DataOne + ": " + TextOne + "\n");
                await FileIO.AppendTextAsync(file, DataTwo + ": " + TextTwo + "\n");
                await FileIO.AppendTextAsync(file, Result + "\n");
                await FileIO.AppendTextAsync(file, "Analysis: "+Analysis);
                // Let Windows know that we're finished changing the file so the other app can update the remote version of the file.
                // Completing updates may require Windows to ask for user input.
                FileUpdateStatus status = await CachedFileManager.CompleteUpdatesAsync(file);
                if (status == FileUpdateStatus.Complete)
                {
                    // Display output if file is saved
                }
                else
                {
                    // Display output if file is not saved
                }
            }
            else
            {
                // File Operation cancelled
            }

        }
        public async void WriteThreeStringObjects(string SuggestedFileName, string DataOne, string TextOne,
          string DataTwo, string TextTwo, string DataThree, string TextThree, string Result)
        {
            FileSavePicker savePicker = new FileSavePicker();
            savePicker.SuggestedStartLocation = PickerLocationId.DocumentsLibrary;
            // Dropdown of file types the user can save the file as
            savePicker.FileTypeChoices.Add("Plain Text", new List<string>() { ".txt" });
            // Default file name if the user does not type one in or select a file to replace
            savePicker.SuggestedFileName = SuggestedFileName;
            StorageFile file = await savePicker.PickSaveFileAsync();
            if (file != null)
            {
                // Prevent updates to the remote version of the file until we finish making changes and call CompleteUpdatesAsync.
                CachedFileManager.DeferUpdates(file);
                // write to file
                await FileIO.WriteTextAsync(file, DataOne + ": " + TextOne + "\n");
                await FileIO.AppendTextAsync(file, DataTwo + ": " + TextTwo + "\n");
                await FileIO.AppendTextAsync(file, DataThree + ": " + TextThree + "\n");
                await FileIO.AppendTextAsync(file, Result);
                // Let Windows know that we're finished changing the file so the other app can update the remote version of the file.
                // Completing updates may require Windows to ask for user input.
                FileUpdateStatus status = await CachedFileManager.CompleteUpdatesAsync(file);
                if (status == FileUpdateStatus.Complete)
                {
                    // Display output if file is saved
                }
                else
                {
                    // Display output if file is not saved
                }
            }
            else
            {
                // File Operation cancelled
            }
        }
        public async void WriteThreeStringObjectsWithAnalysis(string SuggestedFileName, string DataOne, string TextOne,
         string DataTwo, string TextTwo, string DataThree, string TextThree, string Result, string Analysis)
        {
            FileSavePicker savePicker = new FileSavePicker();
            savePicker.SuggestedStartLocation = PickerLocationId.DocumentsLibrary;
            // Dropdown of file types the user can save the file as
            savePicker.FileTypeChoices.Add("Plain Text", new List<string>() { ".txt" });
            // Default file name if the user does not type one in or select a file to replace
            savePicker.SuggestedFileName = SuggestedFileName;
            StorageFile file = await savePicker.PickSaveFileAsync();
            if (file != null)
            {
                // Prevent updates to the remote version of the file until we finish making changes and call CompleteUpdatesAsync.
                CachedFileManager.DeferUpdates(file);
                // write to file
                await FileIO.WriteTextAsync(file, DataOne + ": " + TextOne + "\n");
                await FileIO.AppendTextAsync(file, DataTwo + ": " + TextTwo + "\n");
                await FileIO.AppendTextAsync(file, DataThree + ": " + TextThree + "\n");
                await FileIO.AppendTextAsync(file, Result);
                await FileIO.AppendTextAsync(file, "Analysis: " + Analysis);
                // Let Windows know that we're finished changing the file so the other app can update the remote version of the file.
                // Completing updates may require Windows to ask for user input.
                FileUpdateStatus status = await CachedFileManager.CompleteUpdatesAsync(file);
                if (status == FileUpdateStatus.Complete)
                {
                    // Display output if file is saved
                }
                else
                {
                    // Display output if file is not saved
                }
            }
            else
            {
                // File Operation cancelled
            }
        }

    }
}
