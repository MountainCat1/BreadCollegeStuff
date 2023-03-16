import React, {useEffect, useState} from "react";
import {bubbleSort} from "../../utilities/bubbleSort";

import './ArraySorter.css'

export function ArraySorter() {
    const [input, setInput] = useState<string>("")
    const [output, setOutput] = useState<string>("")

    function onChange(event: React.ChangeEvent<HTMLTextAreaElement>) {
        setInput(event.currentTarget.value);
    }

    function onClick(event: React.MouseEvent) {
        Sort();
    }

    function Sort() {
        let inputFixed: string = input
            .replaceAll(' ', '')
            .replace(/[a-zA-Z]/g, '');

        setInput(inputFixed);

        let inputArray = inputFixed
            .split(',')
            .map(Number)

        let sortedArray = bubbleSort(inputArray);

        setOutput(sortedArray.toString());
    }

    return (
        <div className={'sorter'}>
            <div className={"grid-panel"}>
                <textarea className={'input-field'} value={input} onChange={onChange}/>
            </div>
            <div className={"grid-panel button-panel"}>
                <button className={'sort-button'} onClick={onClick}>
                    Sort!
                </button>
            </div>
            <div className={"grid-panel"}>
                <textarea className={'input-field'} value={output}/>
            </div>
        </div>
    )
}