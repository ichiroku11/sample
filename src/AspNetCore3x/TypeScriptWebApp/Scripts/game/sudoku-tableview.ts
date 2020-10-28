import { Component, SudokuDefault, UndefinedOrDigit } from "./sudoku-helper";

/*
 * 数独table要素ビュー
 */
export class SudokuTableView {
	private readonly _table: HTMLTableElement;

	public constructor(selector: string) {
		const table = document.querySelector<HTMLTableElement>(`${selector} table`);
		if (!table) {
			// todo: 例外よいか？
			throw new Error();
		}

		this._table = table;
	}

	public update(x: Component, y: Component, value: UndefinedOrDigit) {
		const tr = this._table.querySelector<HTMLTableRowElement>(`tr:nth-child(${y})`);
		if (!tr) {
			// todo:
			return;
		}

		const td = tr.querySelector(`td:nth-child(${x})`);
		if (!td) {
			// todo:
			return;
		}

		td.textContent = value === undefined
			? ""
			: value.toString();
	}

	public init(defaults: SudokuDefault[]) {
		for (const { x, y, value } of defaults) {
			this.update(x, y, value);
		}
	}
}
