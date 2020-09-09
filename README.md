# VATACT
Monitor and calculate the Vatsim Air Traffic Controller activity for a specific month. Primarily to be used by the Vatsim ARTCC staff to assist in controller roster maintenance.

#### --Current_Version: V-0.0.8--

![GitHub repo size](https://img.shields.io/github/repo-size/Nikolai558/VATACT)
![GitHub contributors](https://img.shields.io/github/contributors/Nikolai558/VATACT)
![GitHub stars](https://img.shields.io/github/stars/Nikolai558/VATACT?style=social)
![GitHub forks](https://img.shields.io/github/forks/Nikolai558/VATACT?style=social)

## Acknowledgements
   * [@KSanders7070](https://github.com/KSanders7070) - Thanks for helping with UI design, Code implementations, Program Name, Color Scheme, Code Functionality, Batch File Creations, and Supporting my endeavours. 
   * [VATSIM](https://www.vatsim.net/) [API](https://api.vatsim.net/api/) - Thanks for providing some amazing Web based API's free to the public.  

## Prerequisites
   * Windows OS. Other Operating systems are not supported at this time.
   * Stable internet connection
   * Requires a CID list in a text file [ex. CID_List.txt] (one CID per line, no spaces, no empty lines)
   * Requires you to trust the publisher (Nikolas Boling) as there is no security certificate on this program YET.

## [Installation]()
   * Download the current release zip file named "V-x.x.x.zip" where x.x.x is the version number. 
   * Unzip the file.
   * Keep ALL the files together, and place where ever you would like.
   * To run it, click VATACT.exe

## Using VATACT
   * CID Text file field:
      * Requires a full file path {ex. C:\Downloads\CID_LIST.TXT}
   * Month 
      * Two digit month you would like to run this for. {ex. 02 - for Feburary}
   * Year
      * Four digit year {ex. 2020}
   * Minimum Hours Req
      * Two digit number representing the minimum controlling hours required per your ARTCC SOP. {ex 02 - for Two Hour requirement.}
   * Select your Artcc
      * Currently this is hardcoded in with certain ARTCC's. If you do not see yours listed please report as issue at https://github.com/Nikolai558/CID_HOURS_CALCULATOR/issues.
   * Calculate button
      * A couple of things happen in the background when you click on this button.
      * **NOTE**: How far back and how big your CID list is will dramatically increase the time it takes this program to complete. For example: If you select 01/2005 and your CID list is longer then 20, expect it to take 5+ minutes.
         * This program uses two VATSIM API calls to get the necisary information for the CID's in your list. (documentation can be found at https://api.vatsim.net/api/)
            1. https://api.vatsim.net/api/ratings/{person.Cid}/?format=json 
            2. https://api.vatsim.net/api/ratings/{person.Cid}/atcsessions/?format=json
         * This program goes line by line in your CID text file. Once it has completed a line, you will see that CID populate in the "Controller" drop down menu
         * Once you select a controller Two views popup
            1. _ARTCC Code_ Total Hours
               * This lists the total hours for that controller for any callsigns that are valid control posisions.
               * **NOTE**: This is also hardcoded in. If there is an issue please post it at https://github.com/Nikolai558/CID_HOURS_CALCULATOR/issues.
            2. Other Total Hours
               * This list every callsign used that is not included in the "Valid ARTCC Control Callsigns catagory"
      * Once the calculation and API calls are complete, you can then save the output to a text file.
   * CID Text file
      * Requires a directory {ex. C:\downloads\}
   * Save button
      * Look for your newly created text file in the directory you specified.
         * It will be named "{month}_{year}_CID_HOURS.txt" [ex. 08_2020_CID_HOURS.txt]

## Contributions
   * None at this time

## Original Author Contact Information
   * If you would like to contact me, you can reach me at NikBoling@gmail.com

## Additional comments from the Author
   * I know the code source is a little messy right now, however, there are plans to refactor and improve.

## Licence Information
[MIT License](https://github.com/Nikolai558/VATACT/blob/master/LICENSE) Copyright (c) 2020 Nikolas Boling
