# Examination System

The Examination System is a versatile application designed to manage exams and questions for various subjects. This system supports both **Final Exams** and **Practical Exams**, with functionalities tailored to meet distinct requirements for each type.

## Features

- **Question Management**:
  - Base Question class with support for:
    - True or False (Final Exam only)
    - Multiple Choice Questions (MCQs) for both Final and Practical Exams
  - Each Question includes:
    - Header
    - Body
    - Mark
  - Array of answers associated with each question, including the correct answer.

- **Answer Management**:
  - Dedicated `Answer` class to manage:
    - Answer ID
    - Answer Text

- **Exam Management**:
  - Base `Exam` class with:
    - Time allocation
    - Number of questions
    - `ShowExam` functionality (implementation varies by exam type)
  - Supports Final Exams and Practical Exams:
    - Final Exam:
      - Displays Questions, Answers, and Grade.
    - Practical Exam:
      - Shows correct answers after exam completion.

- **Subject Management**:
  - `Subject` class includes:
    - Subject ID
    - Subject Name
    - Associated Exam
    - Functionality to create an exam for a subject.

## Design Principles

- **Object-Oriented Programming (OOP)**:
  - Base and inherited classes to ensure extensibility and clarity.
  - Implements:
    - `ICloneable` for object duplication.
    - `IComparable` for object comparison.
  - Overrides `ToString` for detailed object representation.
  - Constructor chaining where necessary for streamlined initialization.

## Usage

1. **Define a Subject**:
   - Create a `Subject` object to associate with an exam.

2. **Create Questions**:
   - Define question objects based on the required type (e.g., True/False, MCQ).

3. **Assign Answers**:
   - Attach a list of possible answers and specify the correct one.

4. **Setup Exams**:
   - Use the `Exam` base class to create:
     - Final Exams
     - Practical Exams
   - Implement the respective `ShowExam` functionality.

5. **Run the Main Program**:
   - Instantiate a subject and create an exam type as needed.

## Implementation Notes

- **Final Exam**:
  - Focuses on evaluation by displaying questions and grades.
- **Practical Exam**:
  - Ensures learning by revealing correct answers upon completion.

## Technologies and Frameworks

- **Programming Language**: C# or equivalent object-oriented language.
- **Design Patterns**: 
  - Polymorphism for type-specific functionality.
  - Encapsulation for robust class design.

## Contribution

Feel free to fork this repository and contribute to improving the Examination System. All contributions are welcome!

## License

This project is licensed under the MIT License. See the `LICENSE` file for more details.

---

Start building robust and versatile examination systems with ease!
