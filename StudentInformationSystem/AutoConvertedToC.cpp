//.h file code:

#include <string>
#include <vector>
#include <iostream>

 class Program
 {
	public:
		static void Main(std::vector<std::wstring> &args);

		// display the output by printing the information on the screen.
	private:
		static void DisplayInformation(int studentId, const std::wstring &firstName, const std::wstring &surname, const std::wstring &stream);

		// we need the build the surname by skipping all the chars before the first space
		// and add all the rest to make surname.
		static std::wstring ExtractSurname(const std::wstring &fullName);

		// we need to construct first name by adding all the chars from the start of the fullName string
		// till we hit the space char.
		static std::wstring ExtractFirstName(const std::wstring &fullName);

		static int GetStudentId();

		// use the surname's first letter and last 2 digits of student id to allocate the stream.
		static std::wstring AllocateStreams(const std::wstring &surname, int studentId);
 };

//Helper class added by C# to C++ Converter:

#include <string>
#include <vector>

int main(int argc, char **argv)
{
    std::vector<std::wstring> args(argv + 1, argv + argc);
    Program::Main(args);
}

//.cpp file code:

#include "snippet.h"

void Program::Main(std::vector<std::wstring> &args)
{
	// get the name of student from the command prompt / console.
	std::wcout << L"Enter your first and last name as a string: ";

	// save the name in MyName vairable of string.
	std::wstring MyName;
	std::getline(std::wcin, MyName);

	// we use substring from index 0 till the space index to get the first name... eg: John Smith-Ahmed, spaceIndex = 4, subString 0-4 = "John"
	std::wstring FirstName = ExtractFirstName(MyName);

	// the rest of the string is surname so anything after the space index is surname. eg: "Smith-Ahmed"
	std::wstring Surname = ExtractSurname(MyName);

	// get the student id.
	int MyId = GetStudentId();

	// once we have surname and student id, we can now allocate the stream.
	std::wstring stream = AllocateStreams(Surname, MyId);

	// once we have everything, we can display.
	DisplayInformation(MyId, FirstName, Surname, stream);

	// this is to hold the console output until we press enter.
	std::wstring tempVar;
	std::getline(std::wcin, tempVar);
}

void Program::DisplayInformation(int studentId, const std::wstring &firstName, const std::wstring &surname, const std::wstring &stream)
{
	std::wcout << L"\n\n****************************** Stream Information ******************************\n" << std::endl;
	std::wcout << L"================================================================================\n" << std::endl;
	std::wcout << L"Student ID\t\t\tFirst Name\t\t\tFamily Name\t\t\tStream\n" << std::endl;
	std::wcout << L"================================================================================\n" << std::endl;
	std::wcout << studentId << L"\t\t\t" << firstName << L"\t\t\t" << surname << L"\t\t\t" << stream << std::endl;
}

std::wstring Program::ExtractSurname(const std::wstring &fullName)
{
	std::wstring surname = L"";
	int spaceIndex = 0;
	for (int i = 0; i < fullName.length(); i++)
	{
		// we know that first name and surname are separated by space ' ' - the ASCII code for space is 32
		if (fullName[i] == 32)
		{
			spaceIndex = i;
			break;
		}
	}

	// spaceIndex is where the space is, we need to +1 to this so that we can start adding the next char after the space.
	for (int i = spaceIndex + 1; i < fullName.length(); i++)
	{
		surname += fullName[i];
	}

	return surname;

}

std::wstring Program::ExtractFirstName(const std::wstring &fullName)
{
	std::wstring firstName = L"";
	for (int i = 0; i < fullName.length(); i++)
	{
		if (fullName[i] == 32)
		{
			// we know that first name and surname are separated by space ' ' - the ASCII code for space is 32
			break;
		}
		firstName += fullName[i];
	}

	return firstName;
}

int Program::GetStudentId()
{
	int validStudentId = 0;
	while (true)
	{
		// we are using while loop here
		// we will come out of this loop once we have a valid student id.
		try
		{
			std::wcout << L"Enter your student ID as an integer: ";
			std::wstring studentIdString;
			std::getline(std::wcin, studentIdString);

			// int.Parse will throw exception when an invalid number is provided.
			validStudentId = std::stoi(studentIdString);

			// once we have successfully parsed the student id, we need to break from while loop.
			break;
		}
		catch (...)
		{
			// we catch the exception / error and ask the student to try to re-enter the id 
			std::wcout << L"Invalid entry: Please enter 8 digit ID" << std::endl;
		}
	}

	// here we have a valid student id.
	return validStudentId;
}

std::wstring Program::AllocateStreams(const std::wstring &surname, int studentId)
{
	// we need last 2 digits of student id, taking mod of 100 will do just that.
	int last2Digits = studentId % 100;
	wchar_t firstLetterSurname = surname[0];

	// Condition 1:
	if (firstLetterSurname >= 65 && firstLetterSurname <= 79 && last2Digits < 50)
	{
		return L"Stream 20";
	}

	// Condition 2:
	if (firstLetterSurname >= 65 && firstLetterSurname <= 79 && last2Digits >= 50)
	{
		return L"Stream 21";
	}

	// Condition 3:
	if (firstLetterSurname >= 80 && last2Digits < 50)
	{
		return L"Stream 22";
	}

	// Condition 4:
	return L"Stream 23";
}
