import { SudokuQuestions } from "./sudoku-questions";
import { SudokuResolver } from "./sudoku-resolver";
import { SudokuTableView } from "./sudoku-tableview";

document.addEventListener("DOMContentLoaded", _ => {
	const defaults = SudokuQuestions.hard1;

	const resolver = new SudokuResolver(defaults);
	resolver
		.subscribe(
			(x, y, value) => {
				view.update(x, y, value);
			},
			() => {
				alert("Resolved!");
			}
		);

	const view = new SudokuTableView("#sudoku-view");
	view.init(defaults);

	const button = document.querySelector("#sudoku-button-resolve");
	button?.addEventListener("click", () => {
		resolver.resolve();
	});
});
